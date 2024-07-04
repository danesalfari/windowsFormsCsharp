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
    public partial class frmAprendiz : Form
    {
        DAO objDAO = new DAO();
        public frmAprendiz()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            crearAprendiz();
        }
        private void crearAprendiz()
        {
            Aprendiz apr = new Aprendiz();
            apr.DocumentoAprendiz = txtDocumentoAprendiz.Text;
            apr.NombreAprendiz = txtNombreAprendiz.Text;
            objDAO.CrearAprendiz(apr);
            limpiar();
        }
        private void limpiar()
        {
            txtIdAprendiz.Clear();
            txtDocumentoAprendiz.Clear();
            txtNombreAprendiz.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarAprendiz();
        }

        private void buscarAprendiz()
        {
            Aprendiz obj = objDAO.BuscarAprendiz(txtDocumentoAprendiz.Text);
            if (obj != null)
            {
                txtDocumentoAprendiz.Text = obj.DocumentoAprendiz;
                txtNombreAprendiz.Text = obj.NombreAprendiz;
                txtIdAprendiz.Text = obj.IdAprendiz.ToString();
                txtIdAprendiz.Enabled = false;
            }
            else
            {
                MessageBox.Show("El aprendiz ingresado no se encuentra en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarAprendiz();
        }

        private void modificarAprendiz()
        {
            Aprendiz apr = new Aprendiz();

            if (int.TryParse(txtIdAprendiz.Text, out int idAprendiz))
            {
                apr.IdAprendiz = idAprendiz;
                apr.DocumentoAprendiz = txtDocumentoAprendiz.Text;
                apr.NombreAprendiz = txtNombreAprendiz.Text;

                objDAO.ModificarAprendiz(apr);
                limpiar();
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdAprendiz' no es un número válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar()
        {
            Aprendiz apr = new Aprendiz();

            if (int.TryParse(txtIdAprendiz.Text, out int idAprendiz))
            {
                apr.IdAprendiz = idAprendiz;
                apr.DocumentoAprendiz = txtDocumentoAprendiz.Text;
                apr.NombreAprendiz = txtNombreAprendiz.Text;

                var x = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar!", MessageBoxButtons.YesNoCancel);

                if (x == DialogResult.Yes)
                {
                    objDAO.EliminarAprendiz(apr);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("El valor en 'txtIdAprendiz' no es un número válido.");
            }
        }
    }
}
