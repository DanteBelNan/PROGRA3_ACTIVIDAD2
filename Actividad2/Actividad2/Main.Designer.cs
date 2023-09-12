namespace Actividad2
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVerArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModCat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserData = new System.Windows.Forms.Label();
            this.tsmAgrMar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgrCat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArticulos,
            this.tsmAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArticulos
            // 
            this.tsmArticulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVerArticulos,
            this.tsmBuscarArticulo,
            this.tsmAgregarArticulo,
            this.tsmModificarArticulo});
            this.tsmArticulos.Name = "tsmArticulos";
            this.tsmArticulos.Size = new System.Drawing.Size(66, 20);
            this.tsmArticulos.Text = "Articulos";
            // 
            // tsmVerArticulos
            // 
            this.tsmVerArticulos.Name = "tsmVerArticulos";
            this.tsmVerArticulos.Size = new System.Drawing.Size(180, 22);
            this.tsmVerArticulos.Text = "Ver todos";
            this.tsmVerArticulos.Click += new System.EventHandler(this.tsmVerArticulos_Click);
            // 
            // tsmBuscarArticulo
            // 
            this.tsmBuscarArticulo.Name = "tsmBuscarArticulo";
            this.tsmBuscarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmBuscarArticulo.Text = "Buscar Articulo";
            // 
            // tsmAgregarArticulo
            // 
            this.tsmAgregarArticulo.Name = "tsmAgregarArticulo";
            this.tsmAgregarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarArticulo.Text = "Agregar Articulo";
            // 
            // tsmModificarArticulo
            // 
            this.tsmModificarArticulo.Name = "tsmModificarArticulo";
            this.tsmModificarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarArticulo.Text = "Modificar Articulo";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModMarca,
            this.tsmModCat,
            this.tsmAgrMar,
            this.tsmAgrCat});
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            // 
            // tsmModMarca
            // 
            this.tsmModMarca.Name = "tsmModMarca";
            this.tsmModMarca.Size = new System.Drawing.Size(180, 22);
            this.tsmModMarca.Text = "Modificar Marca";
            // 
            // tsmModCat
            // 
            this.tsmModCat.Name = "tsmModCat";
            this.tsmModCat.Size = new System.Drawing.Size(180, 22);
            this.tsmModCat.Text = "Modificar Categoria";
            // 
            // lblUserData
            // 
            this.lblUserData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserData.Location = new System.Drawing.Point(263, 2);
            this.lblUserData.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserData.Size = new System.Drawing.Size(350, 16);
            this.lblUserData.TabIndex = 1;
            this.lblUserData.Text = "userData";
            this.lblUserData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tsmAgrMar
            // 
            this.tsmAgrMar.Name = "tsmAgrMar";
            this.tsmAgrMar.Size = new System.Drawing.Size(180, 22);
            this.tsmAgrMar.Text = "Agregar Marca";
            // 
            // tsmAgrCat
            // 
            this.tsmAgrCat.Name = "tsmAgrCat";
            this.tsmAgrCat.Size = new System.Drawing.Size(180, 22);
            this.tsmAgrCat.Text = "Agregar Categoria";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 388);
            this.Controls.Add(this.lblUserData);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 427);
            this.MinimumSize = new System.Drawing.Size(636, 427);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmModMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmVerArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmModCat;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.ToolStripMenuItem tsmAgrMar;
        private System.Windows.Forms.ToolStripMenuItem tsmAgrCat;
    }
}