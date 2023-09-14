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
            this.dgvBuscarArticulo = new System.Windows.Forms.DataGridView();
            this.tbxBuscarId = new System.Windows.Forms.TextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarArticulo
            // 
            this.dgvBuscarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArticulo.Location = new System.Drawing.Point(12, 64);
            this.dgvBuscarArticulo.Name = "dgvBuscarArticulo";
            this.dgvBuscarArticulo.Size = new System.Drawing.Size(586, 263);
            this.dgvBuscarArticulo.TabIndex = 0;
            this.dgvBuscarArticulo.SelectionChanged += new System.EventHandler(this.dgvBuscarArticulo_SelectionChanged);
            // 
            // tbxBuscarId
            // 
            this.tbxBuscarId.Location = new System.Drawing.Point(119, 21);
            this.tbxBuscarId.Name = "tbxBuscarId";
            this.tbxBuscarId.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscarId.TabIndex = 1; 
            this.btnBuscar.Click += new System.EventHandler(this.tbxBuscarId_TextChanged);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(38, 24);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(75, 13);
            this.lblBuscarId.TabIndex = 2;
            this.lblBuscarId.Text = "Buscar por ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(225, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.tbxBuscarId);
            this.Controls.Add(this.dgvBuscarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BuscarArticulo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvBuscarArticulo;
        private System.Windows.Forms.TextBox tbxBuscarId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Button btnBuscar;
    }
}