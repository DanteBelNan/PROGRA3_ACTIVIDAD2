using dominio;
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

namespace Actividad2
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            Categoria nueva= new Categoria();
            CategoriaDB categoriaDB = new CategoriaDB();

           try
           {
            //nueva.Id = int.Parse(txtIdCat.Text);
            nueva.Descripcion = txtDescCat.Text;
                categoriaDB.agregar(nueva);
                MessageBox.Show("Agregado exitosamente");
                Close();


           }
            catch (Exception ex)
           {
                MessageBox.Show(ex.ToString());
           }

              
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
