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
using dominio;
using negocio;

namespace Actividad2
{
    public partial class VerArticulos : Form
    {

        private List<Articulo> articulos;

        public VerArticulos()
        {
            InitializeComponent();
        }

        private void VerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            articulos = articuloDB.listar();
            dgvArticulos.DataSource = articulos;

            ImagenDB imagenDB = new ImagenDB();
            List<Imagen> imagenes;

            imagenes = imagenDB.listar();


            pbArticulo.Load(imagenes[0].imagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ImagenDB imagenDB = new ImagenDB();
            List<Imagen> imagenes;
            imagenes = imagenDB.listar(articuloActual.id);
            try
            {
                Random random = new Random();
                int index = random.Next(0,imagenes.Count);
                pbArticulo.Load(imagenes[index].imagenUrl);
            }
            catch (Exception ex)
            {
                pbArticulo.Image = null;
            }


        }
    }


}
