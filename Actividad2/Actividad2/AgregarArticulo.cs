using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using dominio;
using negocio;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Actividad2
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Clear();
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                cmbMarca.Items.Add(marca.Descripcion);
            }

            cmbCategoria.Items.Clear();
            CategoriaDB categoriaDB = new CategoriaDB();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaDB.listar();
            foreach(var categoria in listaCategoria)
            {
                cmbCategoria.Items.Add(categoria.Descripcion);
            }

            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 999999999;
            nudPrecio.Increment = 10;

        }

        private bool validateFields()
        {
            if (txbCodigo.Text.Length == 0)
            {
                MessageBox.Show("Codigo sin llenar");
                return false;
            }
            if(txbNombre.Text.Length == 0)
            {
                MessageBox.Show("Nombre sin llenar");
                return false;
            }
            if(txbDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Descripcion sin llenar");
                return false;
            }
            if (!checkMarca())
            {
                return false;
            }
            if (!checkCategoria())
            {
                return false;
            }
            if (yaExiste())
            {
                MessageBox.Show("Ya existe un Articulo con ese codigo");
                return false;
            }
            return true;
        }

        private void addArticle_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                return;
            }
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();
            
            ArticuloDB articuloDB = new ArticuloDB();
            Articulo articulo = new Articulo();
            articulo.codigo = txbCodigo.Text;
            articulo.nombre = txbNombre.Text;
            articulo.descripcion = txbDescripcion.Text;
            articulo.marca = new Marca();
            articulo.marca.Descripcion = cmbMarca.Text;
            articulo.marca.Id = marcaDB.obtener(articulo.marca.Descripcion);
            articulo.categoria = new Categoria();
            articulo.categoria.Descripcion = cmbCategoria.Text;
            articulo.categoria.Id = categoriaDB.obtener(articulo.categoria.Descripcion);
            articulo.precio = nudPrecio.Value;
            
            articuloDB.agregar(articulo);

            Articulo getId = new Articulo();
            getId = articuloDB.obtener(txbCodigo.Text);

            ImagenDB imagenDB = new ImagenDB();

            if (lvUrlImagen.Items.Count == 0)
            {
                //no cargo imagenes
            }
            else
            {
                foreach (ListViewItem item in lvUrlImagen.Items)
                {
                    Imagen imagen = new Imagen();
                    imagen.idArticulo = getId.id;
                    imagen.imagenUrl = item.Text;
                    imagenDB.agregar(imagen);

                }
            }

            MessageBox.Show("Articulo agregado exitosamente");
            txbCodigo.Text = "";
            txbNombre.Text = "";
            txbDescripcion.Text = "";
            cmbMarca.Text = "";
            cmbCategoria.Text = "";
            nudPrecio.Value = 0;
            txbUrlImagen.Text = "";
            lvUrlImagen.Items.Clear();
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {
            int limit = 50;
            if(txbCodigo.Text.Length > limit)
            {
                txbCodigo.Text = txbCodigo.Text.Substring(0, limit);
                txbCodigo.SelectionStart = limit; 
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            int limit = 50;
            if (txbNombre.Text.Length > limit)
            {
                txbNombre.Text = txbCodigo.Text.Substring(0, limit);
                txbNombre.SelectionStart = limit; 
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private void txbDescripcion_TextChanged(object sender, EventArgs e)
        {
            int limit = 150;
            if (txbDescripcion.Text.Length > limit)
            {
                txbDescripcion.Text = txbCodigo.Text.Substring(0, limit);
                txbDescripcion.SelectionStart = limit; 
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private bool checkMarca()
        {
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                if(marca.Descripcion == cmbMarca.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Marca no valida");
            return false;
        }

        private bool checkCategoria()
        {
            CategoriaDB categoriaDB = new CategoriaDB();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaDB.listar();
            foreach (var categoria in listaCategoria)
            {
                if(categoria.Descripcion == cmbCategoria.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Categoria no valida");
            return false;
        }

        public bool yaExiste()
        {
            ArticuloDB articuloDB = new ArticuloDB();
            List<Articulo> articulos = new List<Articulo>();
            articulos = articuloDB.listar();
            foreach(var articulo in articulos)
            {
                if(txbCodigo.Text == articulo.codigo)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {

            if (validarImg())
            {
                txbUrlImagen.Text = "";
                lvUrlImagen.Items.Add(txbUrlImagen.Text);

            }
        }

        private bool validarImg()
        {
            if (txbUrlImagen.Text.Length < 1)
            {
                MessageBox.Show("El texto esta vacio");
                return false;
            }
            if (!isLink(txbUrlImagen.Text))
            {
                return false;
            }
            if (alreadyExist(txbUrlImagen.Text))
            {
                return false;
            }

            return true;
        }


        private bool isLink(string url)
        {
            string https = "https://";
            if (!url.Contains(https)){
                MessageBox.Show("La url no es segura");
                return false;
            }
            return true;
        }

        private bool alreadyExist(string url)
        {
            if(lvUrlImagen.Items.Count == 0)
            {
                return false;
            }
            foreach(ListViewItem item in lvUrlImagen.Items)
            {
                if(item.Text == url)
                {
                    MessageBox.Show("Esta imagen ya existe");
                    return  true;   
                }
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
