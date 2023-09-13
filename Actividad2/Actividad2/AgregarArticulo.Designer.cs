namespace Actividad2
{
    partial class AgregarArticulo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.addArticle = new System.Windows.Forms.Button();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.Precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.85F);
            this.lblTitulo.Location = new System.Drawing.Point(243, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Agregar Articulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addArticle
            // 
            this.addArticle.Location = new System.Drawing.Point(261, 315);
            this.addArticle.Name = "addArticle";
            this.addArticle.Size = new System.Drawing.Size(75, 23);
            this.addArticle.TabIndex = 2;
            this.addArticle.Text = "Agregar";
            this.addArticle.UseVisualStyleBackColor = true;
            this.addArticle.Click += new System.EventHandler(this.addArticle_Click);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(90, 59);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(438, 20);
            this.txbCodigo.TabIndex = 3;
            this.txbCodigo.TextChanged += new System.EventHandler(this.txbCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 62);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(90, 94);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(438, 20);
            this.txbNombre.TabIndex = 5;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.Location = new System.Drawing.Point(90, 131);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(438, 70);
            this.txbDescripcion.TabIndex = 7;
            this.txbDescripcion.Text = "";
            this.txbDescripcion.TextChanged += new System.EventHandler(this.txbDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 159);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(44, 210);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(90, 207);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(438, 21);
            this.cmbMarca.TabIndex = 11;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(90, 239);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(438, 21);
            this.cmbCategoria.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(32, 242);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(90, 266);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(438, 20);
            this.nudPrecio.TabIndex = 15;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(29, 268);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 16;
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
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
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.addArticle);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(508, 338);
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button addArticle;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox txbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label Precio;
    }
}