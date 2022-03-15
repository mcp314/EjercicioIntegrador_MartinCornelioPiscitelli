using EjercicioIntegrador.Datos;
using EjercicioIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Editorial = EjercicioIntegrador.Entidades.Editorial;

namespace EjercicioIntegrador.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private List<Libro> lista;
        private int cantidadRegistros;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosComboEditorial();
            CargarDatosComboTema();
            MostrarCantidadRegistros() ;
            if (cantidadRegistros>0)
            {
                lista = RepositorioDeLibros.GetInstancia().GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void CargarDatosComboEditorial()
        {
            var listaEditoriales = Enum.GetValues(typeof(Editorial)).Cast<Editorial>().ToList();
            foreach (var editorial in listaEditoriales)
            {
                EditorialtoolStripComboBox.Items.Add(editorial);
            }
        }
        private void CargarDatosComboTema()
        {
            var listaTemas = Enum.GetValues(typeof(Tema)).Cast<Tema>().ToList();
            foreach (var tema in listaTemas)
            {
                temaToolStripComboBox.Items.Add(tema);
            }
        }
        private void MostrarCantidadRegistros()
        {
            cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libroCompleto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libroCompleto);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, Libro libroCompleto)
        {
            r.Cells[colRadio.Index].Value = libroCompleto.ISBN;
            r.Cells[colAutor.Index].Value = libroCompleto.Autor;
            r.Cells[ColTitulo.Index].Value = libroCompleto.Titulo;
            r.Cells[colBorde.Index].Value = libroCompleto.Editorial;
            r.Cells[colRelleno.Index].Value = libroCompleto.Tema;
            r.Cells[ColCantidadHojas.Index].Value = libroCompleto.CantidadHojas;

            r.Tag = libroCompleto;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            //capturar los datos
            FrmLibros frm = new FrmLibros() {Text = "Agregar Libro"};
            DialogResult dr = frm.ShowDialog(this);
            //ver si ya no existe
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Libro libroIngresado = frm.GetLibro();
            if (RepositorioDeLibros.GetInstancia().Existe(libroIngresado))
            {
                MessageBox.Show("Libro existente en base de datos!!!", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            //si no existe la guardo
            RepositorioDeLibros.GetInstancia().Agregar(libroIngresado);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r,libroIngresado);
            AgregarFila(r);
            MostrarCantidadRegistros();

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Libro libroABorrar = (Libro) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el libro {libroABorrar.ISBN}?",
                "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            RepositorioDeLibros.GetInstancia().Borrar(libroABorrar);
            DatosDataGridView.Rows.Remove(r);
            MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarCantidadRegistros();
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Libro libroAEditar = (Libro) r.Tag;
            Libro libroCopia = (Libro) libroAEditar.Clone();
            FrmLibros frm = new FrmLibros() {Text = "Editar Libro"};
            frm.SetLibro(libroCopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            libroCopia = frm.GetLibro();
            if (RepositorioDeLibros.GetInstancia().Existe(libroCopia))
            {
                MessageBox.Show("Libro existente!!!", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            RepositorioDeLibros.GetInstancia().Editar(libroAEditar, libroCopia);
            SetearFila(r, libroCopia);
            MessageBox.Show("Registro Modificado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditorialToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditorialtoolStripComboBox.SelectedIndex == -1)
            {
                return;
            }

            Editorial editorial = (Editorial)EditorialtoolStripComboBox.SelectedItem;
            lista = RepositorioDeLibros.GetInstancia().FiltrarPorEditorial(editorial);
            MostrarDatosEnGrilla();
            cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void temaToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (temaToolStripComboBox.SelectedIndex == -1)
            {
                return;
            }

            Tema tema = (Tema) temaToolStripComboBox.SelectedItem;
            lista = RepositorioDeLibros.GetInstancia().FiltrarPorTema(tema);
            MostrarDatosEnGrilla();
            cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }




        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioDeLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            MostrarCantidadRegistros();
        }


        private void AscXRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().OrdenarAscPorCantidadHojas();
            MostrarDatosEnGrilla();
        }

        private void DescXRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().OrdenarDescPorCantidadHojas();
            MostrarDatosEnGrilla();

        }

        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TemaToolStripComboBox_Click(object sender, EventArgs e)
        {

        }
        private void EditorialToolStripComboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
