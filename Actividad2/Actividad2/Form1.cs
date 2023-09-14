using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

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

            Usuario usuario = new Usuario();

            try
            {
                usuario = usuarioDB.obtener(username);
                if(usuario.username == username)
                {
                    if(password == usuario.password)
                    {
                        Main main = new Main(usuario, this);
                        main.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password...");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("User not found...");
                    return;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        private void txbPasswordChanges(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
            
        }
    }
}
