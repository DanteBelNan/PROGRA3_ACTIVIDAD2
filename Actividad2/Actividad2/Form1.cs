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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioDB usuarioDB = new UsuarioDB();
            string username = txbUser.Text;
            string password = txbPassword.Text;

            List<Usuario> lista = new List<Usuario>();
            lista = usuarioDB.listar();
            foreach (Usuario usr in lista)
            {
                if(username == usr.username)
                {
                    if(password == usr.password)
                    {
                        MessageBox.Show("Iniciaste sesion");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password...");
                        return;
                    }
                }
            }
            MessageBox.Show("Usuario no existente...");
            return;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UsuarioDB usuarioDB = new UsuarioDB();
            string username = txbUser.Text;
            string password = txbPassword.Text;
            try
            {
                usuarioDB.Agregar(username, password);
                MessageBox.Show("Usuario agregado");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
