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
        Categoria categoria = new Categoria();

        public ModificarCategoria()
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
            lblDescripcionBuscada.Text= textParaLabel;

        }
        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            string idBuscadoTxt = tbxIdCategoria.Text;
            int idBuscado = Int32.Parse(idBuscadoTxt);

            string nuevaDescTxt = tbxNuevaDescripcion.Text;

            categoriaDB.ModificarDescripcion(idBuscado, nuevaDescTxt);
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
        private void tbxNuevaDescripcion_TextChanged(object sender, EventArgs e)
        {
            int limit = 150;
            if (tbxIdCategoria.Text.Length > limit)
            {
                tbxIdCategoria.Text = tbxIdCategoria.Text.Substring(0, limit);
                tbxIdCategoria.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

    }
}
