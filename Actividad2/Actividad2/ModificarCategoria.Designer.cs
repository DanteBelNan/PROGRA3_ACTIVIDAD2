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
            this.tbxIdCategoria = new System.Windows.Forms.TextBox();
            this.tbxNuevaDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.lblDescripcionAModificar = new System.Windows.Forms.Label();
            this.lblDescripcionBuscada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxIdCategoria
            // 
            this.tbxIdCategoria.Location = new System.Drawing.Point(131, 19);
            this.tbxIdCategoria.Name = "tbxIdCategoria";
            this.tbxIdCategoria.Size = new System.Drawing.Size(48, 20);
            this.tbxIdCategoria.TabIndex = 0;
            this.tbxIdCategoria.TextChanged += new System.EventHandler(this.tbxIdCategoria_TextChanged);
            // 
            // tbxNuevaDescripcion
            // 
            this.tbxNuevaDescripcion.Location = new System.Drawing.Point(44, 205);
            this.tbxNuevaDescripcion.Name = "tbxNuevaDescripcion";
            this.tbxNuevaDescripcion.Size = new System.Drawing.Size(412, 67);
            this.tbxNuevaDescripcion.TabIndex = 2;
            this.tbxNuevaDescripcion.Text = "";
            this.tbxNuevaDescripcion.TextChanged += new System.EventHandler(this.tbxNuevaDescripcion_TextChanged);
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(58, 22);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblIdCategoria.TabIndex = 3;
            this.lblIdCategoria.Text = "Id Categoria:";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(41, 174);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblNuevaDescripcion.TabIndex = 4;
            this.lblNuevaDescripcion.Text = "Nueva Descripcion:";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(185, 13);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(64, 31);
            this.btnBuscarCategoria.TabIndex = 5;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(479, 237);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(66, 35);
            this.btnConfirmarEdicion.TabIndex = 6;
            this.btnConfirmarEdicion.Text = "Editar";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // lblDescripcionAModificar
            // 
            this.lblDescripcionAModificar.AutoSize = true;
            this.lblDescripcionAModificar.Location = new System.Drawing.Point(41, 71);
            this.lblDescripcionAModificar.Name = "lblDescripcionAModificar";
            this.lblDescripcionAModificar.Size = new System.Drawing.Size(120, 13);
            this.lblDescripcionAModificar.TabIndex = 7;
            this.lblDescripcionAModificar.Text = "Descripcion a modificar:";
            // 
            // lblDescripcionBuscada
            // 
            this.lblDescripcionBuscada.AutoSize = true;
            this.lblDescripcionBuscada.Location = new System.Drawing.Point(167, 71);
            this.lblDescripcionBuscada.Name = "lblDescripcionBuscada";
            this.lblDescripcionBuscada.Size = new System.Drawing.Size(52, 13);
            this.lblDescripcionBuscada.TabIndex = 8;
            this.lblDescripcionBuscada.Text = "&Categoria";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.lblDescripcionBuscada);
            this.Controls.Add(this.lblDescripcionAModificar);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.tbxNuevaDescripcion);
            this.Controls.Add(this.tbxIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModificarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIdCategoria;
        private System.Windows.Forms.RichTextBox tbxNuevaDescripcion;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.Label lblDescripcionAModificar;
        private System.Windows.Forms.Label lblDescripcionBuscada;
    }
}