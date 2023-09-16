using dominio;
using negocio;
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
    public partial class EliminarArticulo : Form
    {
        ArticuloDB articuloDB = new ArticuloDB();
        Articulo articulo = new Articulo();

        public EliminarArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txbCodigo.Text;
            articulo = articuloDB.obtener(codigo);

            if (articulo == null)
            {
                MessageBox.Show("Articulo no encontrado");
                deleteArticle.Enabled = false;
                deleteArticle.BackColor = Color.Gray;

            }
            else
            {
                deleteArticle.Enabled = true;
                deleteArticle.BackColor = Color.White;

                txbNombre.Text = articulo.nombre;
                txbDescripcion.Text = articulo.descripcion;
                cmbMarca.Text = articulo.marca.Descripcion;
                cmbCategoria.Text = articulo.categoria.Descripcion;
                nudPrecio.Value = articulo.precio;
            }

        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 9999999999;
            nudPrecio.Increment = 10;
        }

        private void deleteArticle_Click(object sender, EventArgs e)
        {
            if(articulo != null)
            {
                articuloDB.eliminar(articulo.id);
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbDescripcion.Text = "";
                cmbMarca.Text = "";
                cmbCategoria.Text = "";
                nudPrecio.Value = 0;
                deleteArticle.Enabled = false;
                deleteArticle.BackColor = Color.Gray;
            }
        }
    }
}
