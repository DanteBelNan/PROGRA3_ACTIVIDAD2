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
        public Main(Usuario usuario)
        {
            /*this.usuario.id = usuario.id;
            this.usuario.username = usuario.username;
            this.usuario.rol = usuario.rol;*/
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
