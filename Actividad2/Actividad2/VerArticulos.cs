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
        private ImagenDB imagenDB = new ImagenDB();
        private List<Articulo> articulos;
        private List<Imagen> imagenes;
        private int imgLoaded = 0;

        public VerArticulos()
        {
            InitializeComponent();
        }

        private void VerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            try
            {
                articulos = articuloDB.listar();
                dgvArticulos.DataSource = articulos;
                imagenes = imagenDB.listar(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if(imagenes != null)
            {
                imagenes.Clear();
            }
            imgLoaded = 0;
            imagenes = imagenDB.listar(articuloActual.id);
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAdelante.Enabled = true;
            btnAdelante.BackColor = Color.White;

            imgLoaded--;
            if(imgLoaded == 0)
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

        private void Adelante_Click(object sender, EventArgs e)
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
            }catch (Exception ex)
            {
                pbArticulo.Load("https://imgs.search.brave.com/jhh6dmNp1Vbc8vMSSDCk_kkSV6frsAznqf3cmw9LNXI/rs:fit:860:0:0/g:ce/aHR0cHM6Ly93ZXN0/LWdhbWVzLmNvbS93/cC1jb250ZW50L3Vw/bG9hZHMvMjAyMS8w/Ny92dGZlZGl0LWVy/cm9yLWxvYWRpbmct/aW1hZ2UucG5n");
            }
        }
    }


}
