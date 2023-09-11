using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Main : Form
    {
        private Usuario usuario;
        private Form1 form;
        public Main(Usuario usuario, Form1 form)
        {
            this.usuario = new Usuario();
            this.usuario.id = usuario.id;
            this.usuario.username = usuario.username;
            this.usuario.rol = usuario.rol;
            this.form = form;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserData.Text = this.usuario.username + " - " + this.usuario.rol;
            if(this.usuario.rol != "admin")
            {
                tsmAdmin.Visible = false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }

        private void tsmVerArticulos_Click(object sender, EventArgs e)
        {
            VerArticulos verArticulos = new VerArticulos();
            verArticulos.MdiParent = this;
            verArticulos.Show();
        }
    }
}
