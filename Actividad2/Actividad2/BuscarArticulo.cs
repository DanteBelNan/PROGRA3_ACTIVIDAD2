using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace Actividad2
{
    public partial class BuscarArticulo : Form
    {
        private List<Articulo> articulos;
        ArticuloDB articuloDB = new ArticuloDB();
        Articulo articulo = new Articulo();
        public BuscarArticulo()
        {
            InitializeComponent();
        }
        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            articulos = articuloDB.listar();
            dgvBuscarArticulo.DataSource = articulos;
            tbxBuscarId.Text = string.Empty;
        }

        private void dgvBuscarArticulo_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void tbxBuscarId_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idBuscadoTxt = tbxBuscarId.Text;
            int idBuscado = Int32.Parse(idBuscadoTxt);
            articulo = articuloDB.buscarPorId(idBuscado);
        }
    }
}
