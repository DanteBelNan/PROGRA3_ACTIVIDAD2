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
    public partial class ModificarArticulo : Form
    {
        ArticuloDB articuloDB = new ArticuloDB();
        Articulo articulo = new Articulo();
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string codigo = txbCodigo.Text;
            articulo = articuloDB.obtener(codigo);

            if(articulo == null)
            {
                addArticle.Enabled = false;
                addArticle.BackColor = Color.Gray;

            }
            else
            {
                addArticle.Enabled = true;
                addArticle.BackColor = Color.White;

                txbNombre.Text = articulo.nombre;
                txbDescripcion.Text = articulo.descripcion;
                cmbMarca.Text = articulo.Marca;
                cmbCategoria.Text = articulo.Categoria;
                nudPrecio.Value = articulo.precio;

            }


        }

        private void addArticle_Click(object sender, EventArgs e)
        {
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            int id = articulo.id;
            string codigo = txbCodigo.Text;
            string nombre = txbNombre.Text;
            string desc = txbDescripcion.Text;
            string marca = cmbMarca.Text;
            string categoria = cmbCategoria.Text;
            decimal precio = nudPrecio.Value;

            int idMarca = marcaDB.obtener(marca);
            int idCategoria = categoriaDB.obtener(categoria);

            articuloDB.modificar(id, codigo, nombre, desc, idMarca, idCategoria, precio);
        }
    }
}
