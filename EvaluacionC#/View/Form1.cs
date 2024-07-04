using EvaluacionC_.Model;
using EvaluacionC_.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void gestionarAprendicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAprendiz aprendiz = new frmAprendiz();
            aprendiz.MdiParent = this;
            aprendiz.Show();
        }

        private void gestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void gestionarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluacion evaluacion = new frmEvaluacion();
            evaluacion.MdiParent = this;
            evaluacion.Show();
        }

        private void gestionarPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreguntas preguntas = new frmPreguntas();
            preguntas.MdiParent = this;
            preguntas.Show();
        }

        private void gestionarPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrueba prueba = new frmPrueba();
            prueba.MdiParent = this;
            prueba.Show();
        }

        private void gestionarRespuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRespuestas respuestas = new frmRespuestas();
            respuestas.MdiParent = this;
            respuestas.Show();
        }

        private void gestionarTipoPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoPreguntas tipoPreguntas = new frmTipoPreguntas();
            tipoPreguntas.MdiParent = this;
            tipoPreguntas.Show();
        }
    }
}
