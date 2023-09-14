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

namespace Actividad2
{
    public partial class Main : Form
    {
        private Usuario usuario;
        private Form1 form;
        private List<Form> forms = new List<Form>();
        public Main(Usuario usuario, Form1 form)
        {
            this.usuario = new Usuario();
            this.usuario.id = usuario.id;
            this.usuario.username = usuario.username;
            this.usuario.rol = usuario.rol;
            this.form = form;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserData.Text = this.usuario.username + " - " + this.usuario.rol;
            if(this.usuario.rol != "admin")
            {
                tsmAdmin.Visible = false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }

        private void tsmVerArticulos_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            VerArticulos verArticulos = new VerArticulos();
            verArticulos.MdiParent = this;
            verArticulos.Show();
            forms.Add(verArticulos);
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            AgregarArticulo agregarArticulo = new AgregarArticulo();
            agregarArticulo.MdiParent = this;
            agregarArticulo.Show();
            forms.Add(agregarArticulo);
        }

        private void tsmModificarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            ModificarArticulo modificarArticulo = new ModificarArticulo();
            modificarArticulo.MdiParent = this;
            modificarArticulo.Show();
            forms.Add(modificarArticulo);
        }

        private void tsmModMarca_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            ModificarMarca modMarca = new ModificarMarca();
            modMarca.MdiParent = this;
            modMarca.Show();
            forms.Add(modMarca);
        }

        private void tsmModCat_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            ModificarCategoria modificarCategoria = new ModificarCategoria();
            modificarCategoria.MdiParent = this;
            modificarCategoria.Show();
            forms.Add(modificarCategoria);
        }

        private void tsmAgrMar_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            AgregarMarca agregarMarca = new AgregarMarca();
            agregarMarca.MdiParent = this;
            agregarMarca.Show();
            forms.Add(agregarMarca);
        }

        private void tsmAgrCat_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.MdiParent = this;
            agregarCategoria.Show();
            forms.Add(agregarCategoria);

        }

        private void tsmBuscarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
            BuscarArticulo buscarArticulo = new BuscarArticulo();
            buscarArticulo.MdiParent = this;
            buscarArticulo.Show();
            forms.Add(buscarArticulo);
        }
    }
}
