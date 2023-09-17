namespace Actividad2
{
    partial class EliminarCategoria
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
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(89, 64);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(120, 13);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "Seleccionar Categoria:  ";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.AutoEllipsis = true;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(162, 265);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(100, 50);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoEllipsis = true;
            this.btnCancelar.Location = new System.Drawing.Point(318, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(204, 61);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(235, 21);
            this.cbxCategorias.TabIndex = 7;
            // 
            // EliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "EliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EliminarCategoria";
            this.Load += new System.EventHandler(this.EliminarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCategorias;
    }
}