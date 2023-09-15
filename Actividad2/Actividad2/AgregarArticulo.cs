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
            string codigo = txbCodigo.Text;
            string nombre = txbNombre.Text;
            string descripcion = txbDescripcion.Text;
            string marca = cmbMarca.SelectedItem.ToString();
            string categoria = cmbCategoria.SelectedItem.ToString();
            int idMarca = marcaDB.obtener(marca);
            int idCategoria = categoriaDB.obtener(categoria);
            decimal precio = nudPrecio.Value;
            ArticuloDB articuloDB = new ArticuloDB();
            articuloDB.agregar(articuloDB);
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

    }
}
