using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Actividad2
{
    public partial class VerArticulos : Form
    {


        public VerArticulos()
        {
            InitializeComponent();
        }

        private void VerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();

            dgvArticulos.DataSource = articuloDB.listar();
        }
    }


}
