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
            this.tbxIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoriaEliminar = new System.Windows.Forms.Label();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(53, 58);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(73, 13);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "Id Categoria:  ";
            // 
            // tbxIdCategoria
            // 
            this.tbxIdCategoria.Location = new System.Drawing.Point(132, 55);
            this.tbxIdCategoria.Name = "tbxIdCategoria";
            this.tbxIdCategoria.Size = new System.Drawing.Size(40, 20);
            this.tbxIdCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria a eliminar: ";
            // 
            // lblCategoriaEliminar
            // 
            this.lblCategoriaEliminar.AutoSize = true;
            this.lblCategoriaEliminar.Location = new System.Drawing.Point(184, 160);
            this.lblCategoriaEliminar.Name = "lblCategoriaEliminar";
            this.lblCategoriaEliminar.Size = new System.Drawing.Size(11, 13);
            this.lblCategoriaEliminar.TabIndex = 3;
            this.lblCategoriaEliminar.Text = "&*";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(187, 49);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(51, 31);
            this.btnBuscarCategoria.TabIndex = 4;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.AutoEllipsis = true;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(265, 297);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // EliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.lblCategoriaEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIdCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "EliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EliminarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox tbxIdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoriaEliminar;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
    }
}