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
    public partial class frmPreguntas : Form
    {
        DAO objDAO = new DAO();
        List<TipoPreguntas> TipoPreguntas = new List<TipoPreguntas>();
        List<Categorias> Categorias = new List<Categorias>();
        int posT = -1, posC = -1;
        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearPregunta();
        }
        private void crearPregunta()
        {
            Preguntas pre = new Preguntas();
            pre.IdTipoPreguntas = cbxIdTipoPregunta.Text;
            pre.IdCategoria = cbxIdCategoria.Text;
            pre.TextoPregunta = txtTextoPregunta.Text;
            objDAO.CrearPreguntas(pre);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarPregunta();
        }
        private void buscarPregunta()
        {
            Preguntas obj = objDAO.BuscarPreguntas(cbxIdTipoPregunta.Text);
            if (obj != null)
            {
                cbxIdTipoPregunta.Text = obj.IdTipoPreguntas;
                cbxIdCategoria.Text = obj.IdCategoria;
                txtTextoPregunta.Text = obj.TextoPregunta;
                txtIdPregunta.Text = obj.IdTipoPreguntas.ToString();
                txtIdPregunta.Enabled = false;
            }
            else
            {
                MessageBox.Show("La pregunta ingresada no se encuentra en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarPregunta();
        }
        private void modificarPregunta()
        {
            Preguntas pre = new Preguntas();

            if (int.TryParse(txtIdPregunta.Text, out int idPregunta))
            {
                pre.IdPregunta = idPregunta;
                pre.IdTipoPreguntas = cbxIdTipoPregunta.Text;
                pre.IdCategoria = cbxIdCategoria.Text;

                objDAO.ModificarPreguntas(pre);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdPregunta' no es un número válido.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            Preguntas pre = new Preguntas();

            if (int.TryParse(txtIdPregunta.Text, out int idPregunta))
            {
                pre.IdPregunta = idPregunta;
                pre.IdTipoPreguntas = cbxIdTipoPregunta.Text;
                pre.IdCategoria = cbxIdCategoria.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarPreguntas(pre);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdPregunta' no es un número válido.");
            }
        }

        private void llenarCombos()
        {
                TipoPreguntas = objDAO.listarTipoPreguntas();
                Categorias = objDAO.listarCategorias();

                foreach (var t in TipoPreguntas)
                {
                    cbxIdTipoPregunta.Items.Add(t.IdTipoPreguntas);
                }
                foreach (var c in Categorias)
                {
                    cbxIdCategoria.Items.Add(c.IdCategoria);
                }
        }

        private void frmPreguntas_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void cbxIdTipoPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            posT = cbxIdTipoPregunta.SelectedIndex;
        }

        private void cbxIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            posC = cbxIdCategoria.SelectedIndex;
        }

        private void limpiar()
        {
                txtIdPregunta.Clear();
                cbxIdTipoPregunta.Items.Clear();
                cbxIdCategoria.Items.Clear();
                txtTextoPregunta.Clear();
        }
        
    }
}
