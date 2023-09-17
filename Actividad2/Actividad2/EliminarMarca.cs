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
    public partial class EliminarMarca : Form
    {
        public EliminarMarca()
        {
            InitializeComponent();
        }

        private void EliminarMarca_Load(object sender, EventArgs e)
        {
            MarcaDB marcaDB = new MarcaDB();
            try
            {
                cboMarca.DataSource = marcaDB.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion"; 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
           MarcaDB marcaDB = new MarcaDB();
            Marca marca = new Marca();



            try
            {
                DialogResult respuesta= MessageBox.Show("¿Quieres eliminar permanenetemente esta marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    marca = (Marca)cboMarca.SelectedItem;
                    marcaDB.eliminar(marca.Id);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
