namespace Actividad2
{
    partial class AgregarCategoria
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
            this.lblDescCategoria = new System.Windows.Forms.Label();
            this.txtIdCat = new System.Windows.Forms.TextBox();
            this.txtDescCat = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(121, 50);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(16, 13);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "Id";
            // 
            // lblDescCategoria
            // 
            this.lblDescCategoria.AutoSize = true;
            this.lblDescCategoria.Location = new System.Drawing.Point(74, 86);
            this.lblDescCategoria.Name = "lblDescCategoria";
            this.lblDescCategoria.Size = new System.Drawing.Size(63, 13);
            this.lblDescCategoria.TabIndex = 1;
            this.lblDescCategoria.Text = "Descripción";
            // 
            // txtIdCat
            // 
            this.txtIdCat.Enabled = false;
            this.txtIdCat.Location = new System.Drawing.Point(143, 47);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.ReadOnly = true;
            this.txtIdCat.Size = new System.Drawing.Size(123, 20);
            this.txtIdCat.TabIndex = 2;
            // 
            // txtDescCat
            // 
            this.txtDescCat.Location = new System.Drawing.Point(143, 79);
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.Size = new System.Drawing.Size(123, 20);
            this.txtDescCat.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(64, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescCat);
            this.Controls.Add(this.txtIdCat);
            this.Controls.Add(this.lblDescCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 350);
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarCategoria";
            this.Load += new System.EventHandler(this.AgregarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblDescCategoria;
        private System.Windows.Forms.TextBox txtIdCat;
        private System.Windows.Forms.TextBox txtDescCat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}