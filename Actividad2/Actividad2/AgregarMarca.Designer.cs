namespace Actividad2
{
    partial class AgregarMarca
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescMarca = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescMarca
            // 
            this.txtDescMarca.Location = new System.Drawing.Point(115, 73);
            this.txtDescMarca.Name = "txtDescMarca";
            this.txtDescMarca.Size = new System.Drawing.Size(123, 20);
            this.txtDescMarca.TabIndex = 9;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Location = new System.Drawing.Point(115, 41);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.ReadOnly = true;
            this.txtIdMarca.Size = new System.Drawing.Size(123, 20);
            this.txtIdMarca.TabIndex = 8;
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Location = new System.Drawing.Point(46, 80);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(63, 13);
            this.lblDescMarca.TabIndex = 7;
            this.lblDescMarca.Text = "Descripción";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(93, 44);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(16, 13);
            this.lblIdMarca.TabIndex = 6;
            this.lblIdMarca.Text = "Id";
            // 
            // AgregarMarca
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblIdMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "AgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblIdMarca;
    }
}