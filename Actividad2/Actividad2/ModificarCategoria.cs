using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Actividad2
{
    public partial class ModificarCategoria : Form
    {

        CategoriaDB categoriaDB = new CategoriaDB();
        List<Categoria> listaCategoria = new List<Categoria>();

        public ModificarCategoria()
        {
            InitializeComponent();
        }
        private void ModificarCategoria_Load(object sender, EventArgs e)
        {

        }
      
        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            string viejaDescTxt = cbxCategorias.Text;

            string nuevaDescTxt = tbxNuevaDescripcion.Text;

            categoriaDB.ModificarDescripcion(nuevaDescTxt, viejaDescTxt);
            Close();
        }
        
        private void tbxNuevaDescripcion_TextChanged(object sender, EventArgs e)
        {
            int limit = 150;
            if (tbxNuevaDescripcion.Text.Length > limit)
            {
                tbxNuevaDescripcion.Text = tbxNuevaDescripcion.Text.Substring(0, limit);
                tbxNuevaDescripcion.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarCategoria_Load_1(object sender, EventArgs e)
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
