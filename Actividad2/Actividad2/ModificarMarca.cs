using negocio;
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

namespace Actividad2
{
    public partial class ModificarMarca : Form
    {
        public ModificarMarca()
        {
            InitializeComponent();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {

            MarcaDB marcaDB = new MarcaDB();
            List<Marca> marcas = new List<Marca>();
            marcas = marcaDB.listar();

            foreach(Marca marca in marcas)
            {
                cmbMarca.Items.Add(marca);
            }
        }

        private bool checkMarca()
        {
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                if (marca.Descripcion == cmbMarca.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Marca no valida");
            return false;
        }

        private bool checkNewMarca()
        {
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                if (marca.Descripcion == txbNewMarca.Text)
                {
                    MessageBox.Show("Esta marca ya existe");
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkMarca())
            {
                return;
            }
            if(txbNewMarca.Text.Length > 50)
            {
                MessageBox.Show("Una marca no puede tener mas de 50 caracteres");
                return;
            }
            if(!checkNewMarca())
            {
                return;
            }
            if(txbNewMarca.Text.Length < 1)
            {
                MessageBox.Show("El campo esta vacio");
                return;
            }
            MarcaDB marcaDB = new MarcaDB();
            try
            {
                marcaDB.modificar(cmbMarca.SelectedItem.ToString(), txbNewMarca.Text);
                MessageBox.Show("Articulo Modificado");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al modificar el articulo");
            }
            
        }

        private void txbNewMarca_TextChanged(object sender, EventArgs e)
        {
            int limit = 50;
            if (txbNewMarca.Text.Length > limit)
            {
                txbNewMarca.Text = txbNewMarca.Text.Substring(0, limit);
                txbNewMarca.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }
    }
}
