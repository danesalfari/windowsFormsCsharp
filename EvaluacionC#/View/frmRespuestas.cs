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
    public partial class frmRespuestas : Form
    {
        DAO objDAO = new DAO();
        List<Preguntas> Preguntas = new List<Preguntas>();
        int posP = -1;
        public frmRespuestas()
        {
            InitializeComponent();
        }

        private void frmRespuestas_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }
        private void llenarCombos()
        {
            Preguntas = objDAO.listarPreguntasR();

            foreach (var p in Preguntas)
            {
                cbxIdPregunta.Items.Add(p.IdPregunta);
            }
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearRespuestas();
        }
        private void crearRespuestas()
        {
            Respuestas res = new Respuestas();
            res.IdPregunta = cbxIdPregunta.Text;
            res.RespuestaValida = txtRespuestaValida.Text;
            res.TextoRespuesta = txtTextoRespuesta.Text;
            objDAO.CrearRespuestas(res);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRespuestas();
        }
        private void buscarRespuestas()
        {
            Respuestas obj = objDAO.BuscarRespuestas(cbxIdPregunta.Text);
            if (obj != null)
            {
                cbxIdPregunta.Text = obj.IdPregunta;
                txtRespuestaValida.Text = obj.RespuestaValida.ToString();
                txtTextoRespuesta.Text = obj.TextoRespuesta.ToString();
                txtIdRespuesta.Text = obj.IdRespuesta.ToString();
                txtIdRespuesta.Enabled = false;
            }
            else
            {
                MessageBox.Show("La respuesta ingresada no se encuentra en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarRespuestas();
        }
        private void modificarRespuestas()
        {
            Respuestas res = new Respuestas();

            if (int.TryParse(txtIdRespuesta.Text, out int idRespuesta))
            {
                res.IdRespuesta = idRespuesta;
                res.IdPregunta = cbxIdPregunta.Text;
                res.RespuestaValida = txtRespuestaValida.Text;
                res.TextoRespuesta = txtTextoRespuesta.Text;

                objDAO.ModificarRespuestas(res);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdRespuesta' no es un número válido.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar()
        {
            Respuestas res = new Respuestas();

            if (int.TryParse(txtIdRespuesta.Text, out int idRespuesta))
            {
                res.IdRespuesta = idRespuesta;
                res.IdPregunta = cbxIdPregunta.Text;
                res.RespuestaValida = txtRespuestaValida.Text;
                res.TextoRespuesta = txtTextoRespuesta.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarRespuestas(res);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdRespuesta' no es un número válido.");
            }
        }


        private void limpiar()
        {
            txtIdRespuesta.Clear();
            cbxIdPregunta.Items.Clear();
            txtRespuestaValida.Clear();
            txtTextoRespuesta.Clear();
        }

        private void cbxIdPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            posP = cbxIdPregunta.SelectedIndex;
        }
    }
}
