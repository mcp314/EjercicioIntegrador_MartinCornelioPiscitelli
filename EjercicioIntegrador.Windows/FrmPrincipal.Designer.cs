
namespace EjercicioIntegrador.Windows
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadHojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientasToolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorialtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscXRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescXRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.BarraHerramientasToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 581);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 9;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRadio,
            this.ColTitulo,
            this.colAutor,
            this.colBorde,
            this.colRelleno,
            this.ColCantidadHojas});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1136, 455);
            this.DatosDataGridView.TabIndex = 0;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDataGridView_CellContentClick);
            // 
            // colRadio
            // 
            this.colRadio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRadio.HeaderText = "ISBN";
            this.colRadio.MaxInputLength = 10;
            this.colRadio.Name = "colRadio";
            this.colRadio.ReadOnly = true;
            this.colRadio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colBorde
            // 
            this.colBorde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBorde.HeaderText = "Editorial";
            this.colBorde.Name = "colBorde";
            this.colBorde.ReadOnly = true;
            this.colBorde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelleno
            // 
            this.colRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRelleno.HeaderText = "Tema";
            this.colRelleno.Name = "colRelleno";
            this.colRelleno.ReadOnly = true;
            this.colRelleno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCantidadHojas
            // 
            this.ColCantidadHojas.HeaderText = "Cantidad_de_Hojas";
            this.ColCantidadHojas.Name = "ColCantidadHojas";
            this.ColCantidadHojas.ReadOnly = true;
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(142, 25);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadRegistrosLabel.TabIndex = 0;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // BarraHerramientasToolStrip
            // 
            this.BarraHerramientasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.BarraHerramientasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientasToolStrip.Name = "BarraHerramientasToolStrip";
            this.BarraHerramientasToolStrip.Size = new System.Drawing.Size(1136, 58);
            this.BarraHerramientasToolStrip.TabIndex = 8;
            this.BarraHerramientasToolStrip.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.add_file_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.create_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TemaToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.conversion_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorialtoolStripComboBox});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Editorial";
            // 
            // EditorialtoolStripComboBox
            // 
            this.EditorialtoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialtoolStripComboBox.Name = "EditorialtoolStripComboBox";
            this.EditorialtoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.EditorialtoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.EditorialToolStripComboBox_SelectedIndexChanged);
            this.EditorialtoolStripComboBox.Click += new System.EventHandler(this.EditorialToolStripComboBox_Click);
            // 
            // TemaToolStripMenuItem
            // 
            this.TemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripComboBox});
            this.TemaToolStripMenuItem.Name = "TemaToolStripMenuItem";
            this.TemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TemaToolStripMenuItem.Text = "Tema F";
            this.TemaToolStripMenuItem.Click += new System.EventHandler(this.TemaToolStripMenuItem_Click);
            // 
            // temaToolStripComboBox
            // 
            this.temaToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temaToolStripComboBox.Name = "temaToolStripComboBox";
            this.temaToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.temaToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.TemaToolStripComboBox_SelectedIndexChanged);
            this.temaToolStripComboBox.Click += new System.EventHandler(this.TemaToolStripComboBox_Click);
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscXRadioToolStripMenuItem,
            this.DescXRadioToolStripMenuItem,
            this.restaurarStripMenu});
            this.OrdenarToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.up_down_arrow_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AscXRadioToolStripMenuItem
            // 
            this.AscXRadioToolStripMenuItem.Image = global::EjercicioIntegrador.Windows.Properties.Resources.numeric_24px;
            this.AscXRadioToolStripMenuItem.Name = "AscXRadioToolStripMenuItem";
            this.AscXRadioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.AscXRadioToolStripMenuItem.Text = "Asc x Cant. de Hojas";
            this.AscXRadioToolStripMenuItem.Click += new System.EventHandler(this.AscXRadioToolStripMenuItem_Click);
            // 
            // DescXRadioToolStripMenuItem
            // 
            this.DescXRadioToolStripMenuItem.Image = global::EjercicioIntegrador.Windows.Properties.Resources.reversed_numerical_sorting_24px;
            this.DescXRadioToolStripMenuItem.Name = "DescXRadioToolStripMenuItem";
            this.DescXRadioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.DescXRadioToolStripMenuItem.Text = "Desc x Cant de Hojas";
            this.DescXRadioToolStripMenuItem.Click += new System.EventHandler(this.DescXRadioToolStripMenuItem_Click);
            // 
            // restaurarStripMenu
            // 
            this.restaurarStripMenu.Name = "restaurarStripMenu";
            this.restaurarStripMenu.Size = new System.Drawing.Size(184, 22);
            this.restaurarStripMenu.Text = "Restaurar";
            this.restaurarStripMenu.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.restart_36px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(60, 55);
            this.ActualizarToolStripButton.Text = "Restaurar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.close_pane_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BarraHerramientasToolStrip);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Prinicpal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.BarraHerramientasToolStrip.ResumeLayout(false);
            this.BarraHerramientasToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientasToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem TemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox temaToolStripComboBox;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AscXRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescXRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadHojas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox EditorialtoolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem restaurarStripMenu;
    }
}

