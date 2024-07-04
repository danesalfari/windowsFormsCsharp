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

    public partial class frmTipoPreguntas : Form
    {
        DAO objDAO = new DAO();
        public frmTipoPreguntas()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearTipoPregunta();
        }
        private void crearTipoPregunta()
        {
            TipoPreguntas top = new TipoPreguntas();
            top.Tipo = txtTipo.Text;
            objDAO.CrearTipoPreguntas(top);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarTipoPregunta();
        }

        private void buscarTipoPregunta()
        {
            TipoPreguntas obj = objDAO.BuscarTipoPreguntas(txtTipo.Text);
            if (obj != null)
            {
                txtTipo.Text = obj.Tipo;
                txtIdTipoPregunta.Text = obj.IdTipoPreguntas.ToString();
                txtIdTipoPregunta.Enabled = false;
            }
            else
            {
                MessageBox.Show("El tipo de pregunta ingresada no se encuentra en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarTipoPregunta();
        }

        private void modificarTipoPregunta()
        {
            TipoPreguntas top = new TipoPreguntas();

            if (int.TryParse(txtIdTipoPregunta.Text, out int idTipoPregunta))
            {
                top.IdTipoPreguntas = idTipoPregunta;
                top.Tipo = txtTipo.Text;

                objDAO.ModificarTipoPreguntas(top);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdTipoPregunta' no es un número válido.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            TipoPreguntas top = new TipoPreguntas();

            if (int.TryParse(txtIdTipoPregunta.Text, out int idTipoPregunta))
            {
                top.IdTipoPreguntas = idTipoPregunta;
                top.Tipo = txtTipo.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarTipoPreguntas(top);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdTipoPregunta' no es un número válido.");
            }
        }


        private void limpiar()
        {
            txtIdTipoPregunta.Clear();
            txtTipo.Clear();
        }
    }
}
