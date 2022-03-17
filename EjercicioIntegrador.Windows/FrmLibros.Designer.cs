
namespace EjercicioIntegrador.Windows
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditorialComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TemaComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tituloTextbox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.CantidadHojasNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ISBNTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadHojasNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editorial:";
            // 
            // EditorialComboBox
            // 
            this.EditorialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialComboBox.FormattingEnabled = true;
            this.EditorialComboBox.Location = new System.Drawing.Point(124, 96);
            this.EditorialComboBox.Name = "EditorialComboBox";
            this.EditorialComboBox.Size = new System.Drawing.Size(121, 21);
            this.EditorialComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tema:";
            // 
            // TemaComboBox
            // 
            this.TemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemaComboBox.FormattingEnabled = true;
            this.TemaComboBox.Location = new System.Drawing.Point(124, 138);
            this.TemaComboBox.Name = "TemaComboBox";
            this.TemaComboBox.Size = new System.Drawing.Size(121, 21);
            this.TemaComboBox.TabIndex = 2;
            this.TemaComboBox.SelectedIndexChanged += new System.EventHandler(this.RellenoComboBox_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.Guardar;
            this.OkButton.Location = new System.Drawing.Point(28, 195);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(79, 57);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::EjercicioIntegrador.Windows.Properties.Resources.Cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(209, 195);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(79, 57);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Título:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad de hojas:";
            // 
            // tituloTextbox
            // 
            this.tituloTextbox.Location = new System.Drawing.Point(125, 42);
            this.tituloTextbox.Name = "tituloTextbox";
            this.tituloTextbox.Size = new System.Drawing.Size(120, 20);
            this.tituloTextbox.TabIndex = 7;
            this.tituloTextbox.TextChanged += new System.EventHandler(this.TituloTextbox_TextChanged);
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(125, 70);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(120, 20);
            this.autorTextBox.TabIndex = 8;
            // 
            // CantidadHojasNumericUpDown1
            // 
            this.CantidadHojasNumericUpDown1.Location = new System.Drawing.Point(164, 170);
            this.CantidadHojasNumericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CantidadHojasNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadHojasNumericUpDown1.Name = "CantidadHojasNumericUpDown1";
            this.CantidadHojasNumericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.CantidadHojasNumericUpDown1.TabIndex = 9;
            this.CantidadHojasNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadHojasNumericUpDown1.ValueChanged += new System.EventHandler(this.CantidadHojasNumericUpDown1_ValueChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(126, 11);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(119, 20);
            this.ISBNTextBox.TabIndex = 11;
            this.ISBNTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ISBNTextBox_MaskInputRejected);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 293);
            this.ControlBox = false;
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.CantidadHojasNumericUpDown1);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.tituloTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TemaComboBox);
            this.Controls.Add(this.EditorialComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(335, 331);
            this.MinimumSize = new System.Drawing.Size(335, 331);
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos_Del_Libro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadHojasNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EditorialComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TemaComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CantidadHojasNumericUpDown1;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox tituloTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.MaskedTextBox ISBNTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}