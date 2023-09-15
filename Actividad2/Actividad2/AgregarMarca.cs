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
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca  nueva = new Marca();
            MarcaDB marcaDB = new MarcaDB();

            try
            {
                //nueva.Id = int.Parse(txtIdCat.Text);
                nueva.Descripcion = txtDescMarca.Text;
                marcaDB.agregar(nueva);
                MessageBox.Show("Agregado exitosamente");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
