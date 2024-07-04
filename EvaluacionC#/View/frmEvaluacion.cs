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
    public partial class frmEvaluacion : Form
    {
        DAO objDAO = new DAO();
        List<Preguntas> Preguntas = new List<Preguntas>();
        List<Categorias> Categorias = new List<Categorias>();
        int posP = -1, posC = -1;
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEvaluacion();
        }
        private void buscarEvaluacion()
        {
            Evaluacion obj = objDAO.BuscarEvaluacion(cbxIdPregunta.Text);
            if (obj != null)
            {
    
                cbxIdPregunta.Text = obj.IdPregunta;
                txtIdEvaluacion.Text = obj.IdEvaluacion.ToString();
                txtIdEvaluacion.Enabled = false;
            }
            else
            {
                MessageBox.Show("La evaluación ingresada no se encuentra en la base de datos");
            }
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearEvaluacion();
        }
        private void crearEvaluacion()
        {
            Evaluacion eva = new Evaluacion();
            int idEvaluacion;

            if (int.TryParse(txtIdEvaluacion.Text, out idEvaluacion))
            {
                eva.IdEvaluacion = idEvaluacion;
                eva.IdCategoria = cbxCategoria.Text;
                eva.IdPregunta = cbxIdPregunta.Text;
                objDAO.CrearEvaluacion(eva);
            }
            else
            {
                // Manejo del error de conversión
                MessageBox.Show("El valor en 'txtIdEvaluacion' no es un número válido.");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarEvaluacion();
        }

        private void modificarEvaluacion()
        {
            Evaluacion eva = new Evaluacion();

            if (int.TryParse(txtIdEvaluacion.Text, out int idEvaluacion))
            {
                eva.IdEvaluacion = idEvaluacion;
                eva.IdPregunta = cbxIdPregunta.Text;

                objDAO.ModificarEvaluacion(eva);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdEvaluacion' no es un número válido.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            Evaluacion eva = new Evaluacion();

            if (int.TryParse(txtIdEvaluacion.Text, out int idEvaluacion))
            {
                eva.IdEvaluacion = idEvaluacion;
                eva.IdPregunta = cbxIdPregunta.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarEvaluacion(eva);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdEvaluacion' no es un número válido.");
            }
        }


        private void frmEvaluacion_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void llenarCombos()
        {
            Categorias = objDAO.listarCategoriasE();

            foreach (var c in Categorias)
            {
                cbxCategoria.Items.Add(c.Categoria);
            }
        }
        private void limpiar()
        {
            txtIdEvaluacion.Clear();
            cbxIdPregunta.Items.Clear();
            cbxCategoria.Items.Clear();
        }

        private void cbxIdPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            posP = cbxIdPregunta.SelectedIndex;
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            posC = cbxCategoria.SelectedIndex;

            llenarCombos2();

        }
        private void llenarCombos2()
        {
            cbxIdPregunta.Items.Clear();
            MessageBox.Show("Consultando preguntas de la categoría " + cbxCategoria.SelectedText);
            Preguntas = objDAO.listarPreguntas2(cbxCategoria.SelectedText);

            foreach (var p in Preguntas)
            {

                cbxIdPregunta.Items.Add (p.IdPregunta);

            }
        }

    }
}
