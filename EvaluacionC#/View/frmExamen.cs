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
    public partial class frmExamen : Form
    {
        DAO objDAO = new DAO();
        List<PreguntasRespuestas> PreguntasRespuestas = new List<PreguntasRespuestas>();
        string IdEval, tipoPregunta, IdPru;
        int preguntas, correctas, indice;
        float resultado;
        public frmExamen(string IdEvaluacion, string IdPrueba)
        {
            InitializeComponent();
            IdEval = IdEvaluacion;
            IdPru = IdPrueba;
        }

        private void frmExamen_Load(object sender, EventArgs e)
        {
            PreguntasRespuestas = objDAO.listarPreguntasRespuestas(IdEval);
            preguntas = 0;
            correctas = 0;
            indice = 0;

            mostrarPregunta();


            /*foreach (var p in PreguntasRespuestas)
            {
                cbxCategoria.Items.Add(p.Categoria);
            }*/
        }

        private void mostrarPregunta()
        {
            if(indice < PreguntasRespuestas.Count)
            {
                label1.Text = PreguntasRespuestas.ElementAt(indice).TextoPregunta;
                
                tipoPregunta = PreguntasRespuestas.ElementAt(indice).Tipo;

                if (PreguntasRespuestas.ElementAt(indice).Tipo.Equals("FALSO O VERDADERO"))
                {
                    radioButton1.Visible = true; 
                    radioButton2.Visible = true;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    checkBox1.Visible = false; 
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;

                    label2.Text = PreguntasRespuestas.ElementAt(indice).RespuestaValida;
                    label3.Text = PreguntasRespuestas.ElementAt(indice + 1).RespuestaValida;

                    radioButton1.Text = PreguntasRespuestas.ElementAt(indice).TextoRespuesta;
                    radioButton2.Text = PreguntasRespuestas.ElementAt(indice + 1).TextoRespuesta;
                    indice = indice + 2;
                    preguntas = preguntas + 1;

                }
                else if (PreguntasRespuestas.ElementAt(indice).Tipo.Equals("RESPUESTA UNICA"))                  
                {
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;

                    label2.Text = PreguntasRespuestas.ElementAt(indice).RespuestaValida;
                    label3.Text = PreguntasRespuestas.ElementAt(indice + 1).RespuestaValida;
                    label4.Text = PreguntasRespuestas.ElementAt(indice + 2).RespuestaValida;
                    label5.Text = PreguntasRespuestas.ElementAt(indice + 3).RespuestaValida;

                    radioButton1.Text = PreguntasRespuestas.ElementAt(indice).TextoRespuesta;
                    radioButton2.Text = PreguntasRespuestas.ElementAt(indice + 1).TextoRespuesta;
                    radioButton3.Text = PreguntasRespuestas.ElementAt(indice + 2).TextoRespuesta;
                    radioButton4.Text = PreguntasRespuestas.ElementAt(indice + 3).TextoRespuesta;
                    indice = indice + 4;
                    preguntas = preguntas + 1;

                }
                else if (PreguntasRespuestas.ElementAt(indice).Tipo.Equals("SELECCION MULTIPLE"))
                {
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = true;
                    checkBox4.Visible = true;

                    label2.Text = PreguntasRespuestas.ElementAt(indice).RespuestaValida;
                    label3.Text = PreguntasRespuestas.ElementAt(indice + 1).RespuestaValida;
                    label4.Text = PreguntasRespuestas.ElementAt(indice + 2).RespuestaValida;
                    label5.Text = PreguntasRespuestas.ElementAt(indice + 3).RespuestaValida;


                    checkBox1.Text = PreguntasRespuestas.ElementAt(indice).TextoRespuesta;
                    checkBox2.Text = PreguntasRespuestas.ElementAt(indice + 1).TextoRespuesta;
                    checkBox3.Text = PreguntasRespuestas.ElementAt(indice + 2).TextoRespuesta;
                    checkBox4.Text = PreguntasRespuestas.ElementAt(indice + 3).TextoRespuesta;
                    indice = indice + 4;
                    preguntas = preguntas + 1;

                }
            }
        }
        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (tipoPregunta.Equals("FALSO O VERDADERO"))
            {
                if ((label2.Text.Equals("S") && radioButton1.Checked == true) || (label3.Text.Equals("S") && radioButton2.Checked == true))
                {
                    correctas = correctas + 1;
                    MessageBox.Show("Respuesta Correcta");
                }
                else
                {
                    MessageBox.Show("Respuesta Incorrecta");
                }

            }
            else if (tipoPregunta.Equals("RESPUESTA UNICA"))
            {
                if ((label2.Text.Equals("S") && radioButton1.Checked == true) || (label3.Text.Equals("S") && radioButton2.Checked == true) ||
                    (label4.Text.Equals("S") && radioButton3.Checked == true) || (label5.Text.Equals("S") && radioButton4.Checked == true))                
                {
                    correctas = correctas + 1;
                    MessageBox.Show("Respuesta Correcta");
                }
                else
                {
                    MessageBox.Show("Respuesta Incorrecta");
                }

            }
            else if (tipoPregunta.Equals("SELECCION MULTIPLE"))
            {
                if (
                    ((label2.Text.Equals("S") && checkBox1.Checked == true) || (label2.Text.Equals("N") && checkBox1.Checked == false)) &&
                    ((label3.Text.Equals("S") && checkBox2.Checked == true) || (label3.Text.Equals("N") && checkBox2.Checked == false)) &&
                    ((label4.Text.Equals("S") && checkBox3.Checked == true) || (label4.Text.Equals("N") && checkBox3.Checked == false)) &&
                    ((label5.Text.Equals("S") && checkBox4.Checked == true) || (label5.Text.Equals("N") && checkBox4.Checked == false)) 
                    )
                {
                    correctas = correctas + 1;
                    MessageBox.Show("Respuesta Correcta");
                }
                else
                {
                    MessageBox.Show("Respuesta Incorrecta");
                }

            }

            if(indice >= PreguntasRespuestas.Count)
            {
                resultado = correctas * 100 / preguntas;
                MessageBox.Show("Su resultado es: " + resultado.ToString() + "%");
                objDAO.escribirResultados(resultado.ToString(), IdPru);
                this.Close();
            }


            mostrarPregunta();
        }
    }
}
