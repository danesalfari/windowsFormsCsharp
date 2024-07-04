using EvaluacionC_.Controller;
using EvaluacionC_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionC_.View
{
    public partial class frmCategorias : Form
    {
        DAO objDAO = new DAO();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearCategoria();
        }

        private void crearCategoria()
        {
            Categorias cat = new Categorias();
            cat.Categoria = txtCategoria.Text;
            objDAO.CrearCategorias(cat);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCategoria();
        }

        private void buscarCategoria()
        {
            Categorias obj = objDAO.BuscarCategorias(txtCategoria.Text);
            if (obj != null)
            {
                txtCategoria.Text = obj.Categoria;
                txtIdCategoria.Text = obj.IdCategoria.ToString();
                txtIdCategoria.Enabled = false;
            }
            else
            {
                MessageBox.Show("La categoría ingresada no se encuentra en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarCategoria();
        }

        private void modificarCategoria()
        {
            Categorias cat = new Categorias();

            if (int.TryParse(txtIdCategoria.Text, out int idCategoria))
            {
                cat.IdCategoria = idCategoria;
                cat.Categoria = txtCategoria.Text;

                objDAO.ModificarCategorias(cat);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdCategoria' no es un número válido.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            Categorias cat = new Categorias();

            if (int.TryParse(txtIdCategoria.Text, out int idCategoria))
            {
                cat.IdCategoria = idCategoria;
                cat.Categoria = txtCategoria.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarCategorias(cat);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdCategoria' no es un número válido.");
            }
        }


        private void limpiar()
        {
            txtIdCategoria.Clear();
            txtCategoria.Clear();
        }
    }
}
