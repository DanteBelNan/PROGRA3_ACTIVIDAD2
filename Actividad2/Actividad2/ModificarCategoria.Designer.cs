namespace Actividad2
{
    partial class ModificarCategoria
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
            this.tbxNuevaDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxNuevaDescripcion
            // 
            this.tbxNuevaDescripcion.Location = new System.Drawing.Point(44, 177);
            this.tbxNuevaDescripcion.Name = "tbxNuevaDescripcion";
            this.tbxNuevaDescripcion.Size = new System.Drawing.Size(412, 95);
            this.tbxNuevaDescripcion.TabIndex = 2;
            this.tbxNuevaDescripcion.Text = "";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(58, 22);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(111, 13);
            this.lblIdCategoria.TabIndex = 3;
            this.lblIdCategoria.Text = "Seleccione Categoria:";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(41, 148);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblNuevaDescripcion.TabIndex = 4;
            this.lblNuevaDescripcion.Text = "Nueva Descripcion:";
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(481, 197);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(66, 35);
            this.btnConfirmarEdicion.TabIndex = 6;
            this.btnConfirmarEdicion.Text = "Editar";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(481, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(175, 19);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(207, 21);
            this.cbxCategorias.TabIndex = 10;
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.tbxNuevaDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModificarCategoria";
            this.Load += new System.EventHandler(this.ModificarCategoria_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbxNuevaDescripcion;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCategorias;
    }
}