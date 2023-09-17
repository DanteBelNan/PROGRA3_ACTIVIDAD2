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
    public partial class EliminarCategoria : Form
    {
        CategoriaDB categoriaDB = new CategoriaDB();
        List<Categoria> listaCategoria = new List<Categoria>();

        public EliminarCategoria()
        {
            InitializeComponent();
        }


        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            string BuscadoTxt = cbxCategorias.Text;

            categoriaDB.EliminarCategoria(BuscadoTxt);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarCategoria_Load(object sender, EventArgs e)
        {
            cbxCategorias.Items.Clear();
            listaCategoria = categoriaDB.listar();
            foreach (var categoria in listaCategoria)
            {
                cbxCategorias.Items.Add(categoria);
            }
        }
    }
}
