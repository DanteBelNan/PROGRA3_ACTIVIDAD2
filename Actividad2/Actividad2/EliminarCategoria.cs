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
        Categoria categoria = new Categoria();

        public EliminarCategoria()
        {
            InitializeComponent();
        }
        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
        }


        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {

            string idBuscadoTxt = tbxIdCategoria.Text;
            int idBuscado = Int32.Parse(idBuscadoTxt);

            string textParaLabel = categoriaDB.obtener(idBuscado);
            lblCategoriaEliminar.Text = textParaLabel;

        }
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            string idBuscadoTxt = tbxIdCategoria.Text;
            int idBuscado = Int32.Parse(idBuscadoTxt);
            categoriaDB.EliminarCategoria(idBuscado);

        
        }

        private void tbxIdCategoria_TextChanged(object sender, EventArgs e)
        {
            int limit = 5;
            if (tbxIdCategoria.Text.Length > limit)
            {
                tbxIdCategoria.Text = tbxIdCategoria.Text.Substring(0, limit);
                tbxIdCategoria.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
