using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioIntegrador.Entidades;
using Tema = EjercicioIntegrador.Entidades.Tema;
using Editorial = EjercicioIntegrador.Entidades.Editorial;
using EjercicioIntegrador.Datos;
using probando = EjercicioIntegrador.Datos.RepositorioDeLibros;


namespace EjercicioIntegrador.Windows
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditorial(ref EditorialComboBox);
            CargarDatosComboTema(ref TemaComboBox);
            if (libroCompleto!=null)
            {
                ISBNTextBox.Text = libroCompleto.ISBN;
                tituloTextbox.Text = libroCompleto.Titulo;
                autorTextBox.Text = libroCompleto.Autor;
                EditorialComboBox.SelectedItem = libroCompleto.Editorial;
                TemaComboBox.SelectedItem = libroCompleto.Tema;
                CantidadHojasNumericUpDown1.Value = libroCompleto.CantidadHojas;
            }
        }

        private void CargarDatosComboTema(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Tema));
        }

        private void CargarDatosComboEditorial(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Editorial));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Libro libroCompleto;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (libroCompleto==null)
                {
                    libroCompleto = new Libro();
                }

                libroCompleto.ISBN = ISBNTextBox.Text;
                libroCompleto.Titulo = tituloTextbox.Text;
                libroCompleto.Autor = autorTextBox.Text;
                libroCompleto.Editorial =(Editorial) EditorialComboBox.SelectedItem;
                libroCompleto.Tema = (Tema) TemaComboBox.SelectedItem;
                libroCompleto.CantidadHojas = (int) CantidadHojasNumericUpDown1.Value;

                DialogResult = DialogResult.OK;
            }
        }

        //Para que se ejecuten todas las verificaciones a la vez, al grabar libro
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            int resultado = 0;
            resultado = resultado + ValidarISBN();
            resultado = resultado + ValidarAutor();
            resultado = resultado + ValidarTitulo();
            resultado = resultado + ValidarCantidadHojas();
            if (resultado > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        private int ValidarISBN()
        {

            if (!String.IsNullOrEmpty(ISBNTextBox.Text))
            {
                RepositorioDeLibros.GetInstancia();
                return 0;
            }
            else
            {
                errorProvider1.SetError(ISBNTextBox, "el número de ISBN no puede ser nulo ni repetido");
                return 1;

            }

        }

       
private int ValidarTitulo()
        {
            if (!String.IsNullOrEmpty(tituloTextbox.Text))
            {
                return 0;
            }
            else
            {
                errorProvider2.SetError(tituloTextbox, "Ingrese un título para el libro");
                return 1;
            }

        }

    private int ValidarAutor()
        {

            if (!String.IsNullOrEmpty(autorTextBox.Text))
            {
                return 0;
            }
            else
            {
                errorProvider3.SetError(autorTextBox, "Ingrese el autor del libro");
                return 1;
            }

        }
        private int ValidarCantidadHojas()
        {

            if (CantidadHojasNumericUpDown1.Value > 0)
            {
                return 0;
            }
            else
            {
                errorProvider4.SetError(CantidadHojasNumericUpDown1, "Verifique la cantidad de hojas ingresada");
                return 1;
            }

        }

        public Libro GetLibro()
        {
            return libroCompleto;
        }

        public void SetLibro(Libro circCopia)
        {
            libroCompleto = circCopia;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RellenoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tituloTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadHojasNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //if (ValidarCantidadHojas())
            //{
            //    errorProvider1.SetError(CantidadHojasNumericUpDown1, "Cantidad de hojas debe ser mayor a cero");
            //}  ;
        }

        private void ISBNTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
