﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

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
                MessageBox.Show("Articulo no encontrado");
                addArticle.Enabled = false;
                addArticle.BackColor = Color.Gray;

            }
            else
            {
                addArticle.Enabled = true;
                addArticle.BackColor = Color.White;

                txbNombre.Text = articulo.nombre;
                txbDescripcion.Text = articulo.descripcion;
                cmbMarca.Text = articulo.marca.Descripcion;
                cmbCategoria.Text = articulo.categoria.Descripcion;
                nudPrecio.Value = articulo.precio;

                MarcaDB marcaDB = new MarcaDB();
                CategoriaDB categoriaDB = new CategoriaDB();
                List<Marca> marcas = new List<Marca>();
                List<Categoria> categorias = new List<Categoria>();

                marcas = marcaDB.listar();
                categorias = categoriaDB.listar();
                foreach (Marca marca in marcas)
                {
                    cmbMarca.Items.Add(marca.Descripcion);
                }
                foreach (Categoria categoria in categorias)
                {
                    cmbCategoria.Items.Add(categoria.Descripcion);
                }

            }


        }

        private void addArticle_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                return;
            }
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
            this.Close();
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {
            int limit = 50;
            if (txbCodigo.Text.Length > limit)
            {
                txbCodigo.Text = txbCodigo.Text.Substring(0, limit);
                txbCodigo.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            int limit = 50;
            if (txbNombre.Text.Length > limit)
            {
                txbNombre.Text = txbCodigo.Text.Substring(0, limit);
                txbNombre.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
            }
        }

        private void txbDescripcion_TextChanged(object sender, EventArgs e)
        {
            int limit = 150;
            if (txbDescripcion.Text.Length > limit)
            {
                txbDescripcion.Text = txbCodigo.Text.Substring(0, limit);
                txbDescripcion.SelectionStart = limit;
                MessageBox.Show("Se ha alcanzado el límite máximo de caracteres.");
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

        private bool checkCategoria()
        {
            CategoriaDB categoriaDB = new CategoriaDB();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaDB.listar();
            foreach (var categoria in listaCategoria)
            {
                if (categoria.Descripcion == cmbCategoria.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Categoria no valida");
            return false;
        }

        private bool validateFields()
        {
            if (txbCodigo.Text.Length == 0)
            {
                MessageBox.Show("Codigo sin llenar");
                return false;
            }
            if (txbNombre.Text.Length == 0)
            {
                MessageBox.Show("Nombre sin llenar");
                return false;
            }
            if (txbDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Descripcion sin llenar");
                return false;
            }
            if (!checkMarca())
            {
                return false;
            }
            if (!checkCategoria())
            {
                return false;
            }
            return true;
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 9999999999;
            nudPrecio.Increment = 10;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
