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
        private List<Articulo> articulos = new List<Articulo>();
        ArticuloDB articuloDB = new ArticuloDB();
        Articulo articulo = new Articulo();
        ImagenDB imagenDB = new ImagenDB();
        List<Imagen> imagenes = new List<Imagen>();
        public BuscarArticulo()
        {
            InitializeComponent();
        }
        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            articulos = articuloDB.listar();
            foreach (Articulo articulo in articulos)
            {
                cmbCodigos.Items.Add(articulo.codigo);
            }

            cmbCodigos.Text = string.Empty;
            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 99999999999;
        }

        int imgLoaded;
        private void cmbCodigos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codigo = cmbCodigos.Text;
            articulo = articuloDB.obtener(codigo);

            if (articulo == null)
            {
                MessageBox.Show("Articulo no encontrado");


            }
            else
            {

                txbNombre.Text = articulo.nombre;
                txbDescripcion.Text = articulo.descripcion;
                cmbMarca.Text = articulo.marca.Descripcion;
                cmbCategoria.Text = articulo.categoria.Descripcion;
                nudPrecio.Value = articulo.precio;


                imgLoaded = 0;
                imagenes = imagenDB.listar(articulo.id);
                btnAtras.Enabled = false;
                btnAtras.BackColor = Color.Gray;
                if (imagenes.Count > 1)
                {
                    btnAdelante.Enabled = true;
                    btnAdelante.BackColor = Color.White;
                }
                else
                {
                    btnAdelante.Enabled = false;
                    btnAdelante.BackColor = Color.Gray;
                }
                try
                {
                    pbArticulo.Load(imagenes[imgLoaded].imagenUrl);
                }
                catch (Exception ex)
                {
                    pbArticulo.Load("https://imgs.search.brave.com/S3T3B8nahnuwGHbVWX6JrrDTeQ9cKkw7nxC8Vabl9lU/rs:fit:860:0:0/g:ce/aHR0cHM6Ly90NC5m/dGNkbi5uZXQvanBn/LzAwLzg5LzU1LzE1/LzM2MF9GXzg5NTUx/NTk2X0xkSEFaUnd6/M2k0RU00SjBOSE5I/eTJoRVVZRGZYYzBq/LmpwZw");
                }


            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            imgLoaded++;
            btnAtras.Enabled = true;
            btnAtras.BackColor = Color.White;
            if (imagenes.Count - 2 <= imgLoaded)
            {
                btnAdelante.Enabled = false;
                btnAdelante.BackColor = Color.Gray;
            }
            else
            {
                btnAdelante.Enabled = true;
                btnAdelante.BackColor = Color.White;
            }
            try
            {
                pbArticulo.Load(imagenes[imgLoaded].imagenUrl);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://imgs.search.brave.com/jhh6dmNp1Vbc8vMSSDCk_kkSV6frsAznqf3cmw9LNXI/rs:fit:860:0:0/g:ce/aHR0cHM6Ly93ZXN0/LWdhbWVzLmNvbS93/cC1jb250ZW50L3Vw/bG9hZHMvMjAyMS8w/Ny92dGZlZGl0LWVy/cm9yLWxvYWRpbmct/aW1hZ2UucG5n");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAdelante.Enabled = true;
            btnAdelante.BackColor = Color.White;

            imgLoaded--;
            if (imgLoaded == 0)
            {
                btnAtras.Enabled = false;
                btnAtras.BackColor = Color.Gray;
            }
            else
            {
                btnAtras.Enabled = true;
                btnAtras.BackColor = Color.White;
            }
            try
            {
                pbArticulo.Load(imagenes[imgLoaded].imagenUrl);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://imgs.search.brave.com/jhh6dmNp1Vbc8vMSSDCk_kkSV6frsAznqf3cmw9LNXI/rs:fit:860:0:0/g:ce/aHR0cHM6Ly93ZXN0/LWdhbWVzLmNvbS93/cC1jb250ZW50L3Vw/bG9hZHMvMjAyMS8w/Ny92dGZlZGl0LWVy/cm9yLWxvYWRpbmct/aW1hZ2UucG5n");
            }
        }

    }
}
