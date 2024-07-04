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
    public partial class frmPrueba : Form
    {
        DAO objDAO = new DAO();
        List<Aprendiz> Aprendiz = new List<Aprendiz>();
        List<Evaluacion> Evaluacion = new List<Evaluacion>();
        int posA = -1, posE = -1;
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarPrueba();
        }
        private void buscarPrueba()
        {
            Prueba obj = objDAO.BuscarPrueba(txtIdPrueba.Text);
            if (obj != null)
            {
                cbxIdAprendiz.Text = obj.IdAprendiz;
                cbxIdEvaluacion.Text = obj.IdEvaluacion;
                txtIdPrueba.Text = obj.IdPrueba.ToString();
                txtIdPrueba.Enabled = false;
            }
            else
            {
                MessageBox.Show("La prueba ingresada no se encuentra en la base de datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar()
        {
            Prueba pru = new Prueba();

            if (int.TryParse(txtIdPrueba.Text, out int idPrueba))
            {
                pru.IdPrueba = ""+idPrueba;
                pru.IdAprendiz = cbxIdAprendiz.Text;
                pru.IdEvaluacion = cbxIdEvaluacion.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarPrueba(pru);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdPrueba' no es un número válido.");
            }
        }

        private void cbxIdEvaluacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            posE = cbxIdEvaluacion.SelectedIndex;
        }

        private void cbxIdAprendiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            posA = cbxIdAprendiz.SelectedIndex;
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crear();
        }
        private void crear()
        {
            Prueba pre = new Prueba();
            pre.IdAprendiz = cbxIdAprendiz.Text;
            pre.IdEvaluacion = cbxIdEvaluacion.Text;
            pre.IdPrueba = txtIdPrueba.Text;
            objDAO.CrearPrueba(pre);
        }
        private void llenarCombos()
        {
            Evaluacion = objDAO.listarEvaluacion();
            Aprendiz = objDAO.listarAprendiz();

            foreach (var e in Evaluacion)
            {
                cbxIdEvaluacion.Items.Add(e.IdEvaluacion);
            }
            foreach (var a in Aprendiz)
            {
                cbxIdAprendiz.Items.Add(a.IdAprendiz);
            }
        }

        private void limpiar()
        {
            txtIdPrueba.Clear();
            cbxIdEvaluacion.Items.Clear();
            cbxIdAprendiz.Items.Clear();
        }
    }
}
