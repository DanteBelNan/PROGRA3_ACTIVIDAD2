namespace Actividad2
{
    partial class BuscarArticulo
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

        private void InitializeComponent()
        {
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Precio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(139, 21);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigo.TabIndex = 1;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(38, 24);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(97, 13);
            this.lblBuscarId.TabIndex = 2;
            this.lblBuscarId.Text = "Buscar por Codigo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(245, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(13, 245);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 30;
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.Color.White;
            this.nudPrecio.Enabled = false;
            this.nudPrecio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudPrecio.Location = new System.Drawing.Point(74, 243);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(275, 20);
            this.nudPrecio.TabIndex = 29;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 209);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(74, 206);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(275, 21);
            this.cmbCategoria.TabIndex = 27;
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.White;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Enabled = false;
            this.cmbMarca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(74, 171);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(275, 21);
            this.cmbMarca.TabIndex = 26;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 174);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(5, 118);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 24;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.BackColor = System.Drawing.Color.White;
            this.txbDescripcion.Enabled = false;
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbDescripcion.Location = new System.Drawing.Point(74, 90);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(275, 70);
            this.txbDescripcion.TabIndex = 23;
            this.txbDescripcion.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.White;
            this.txbNombre.Enabled = false;
            this.txbNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbNombre.Location = new System.Drawing.Point(74, 63);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(275, 20);
            this.txbNombre.TabIndex = 21;
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdelante.Enabled = false;
            this.btnAdelante.Location = new System.Drawing.Point(500, 253);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(75, 23);
            this.btnAdelante.TabIndex = 33;
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.UseVisualStyleBackColor = false;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtras.Enabled = false;
            this.btnAtras.Location = new System.Drawing.Point(404, 253);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbArticulo.Location = new System.Drawing.Point(404, 79);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(171, 162);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 31;
            this.pbArticulo.TabStop = false;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.txbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BuscarArticulo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox txbDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pbArticulo;
    }
}