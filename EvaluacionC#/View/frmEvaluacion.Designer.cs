namespace EvaluacionC_.View
{
    partial class frmEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdEvaluacion = new System.Windows.Forms.TextBox();
            this.lblIdEvaluacion = new System.Windows.Forms.Label();
            this.lblIdPregunta = new System.Windows.Forms.Label();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxIdPregunta = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdEvaluacion
            // 
            this.txtIdEvaluacion.Location = new System.Drawing.Point(146, 12);
            this.txtIdEvaluacion.Name = "txtIdEvaluacion";
            this.txtIdEvaluacion.Size = new System.Drawing.Size(250, 20);
            this.txtIdEvaluacion.TabIndex = 16;
            // 
            // lblIdEvaluacion
            // 
            this.lblIdEvaluacion.AutoSize = true;
            this.lblIdEvaluacion.Location = new System.Drawing.Point(10, 19);
            this.lblIdEvaluacion.Name = "lblIdEvaluacion";
            this.lblIdEvaluacion.Size = new System.Drawing.Size(75, 13);
            this.lblIdEvaluacion.TabIndex = 15;
            this.lblIdEvaluacion.Text = "Id Evaluación:";
            // 
            // lblIdPregunta
            // 
            this.lblIdPregunta.AutoSize = true;
            this.lblIdPregunta.Location = new System.Drawing.Point(10, 92);
            this.lblIdPregunta.Name = "lblIdPregunta";
            this.lblIdPregunta.Size = new System.Drawing.Size(65, 13);
            this.lblIdPregunta.TabIndex = 17;
            this.lblIdPregunta.Text = "Id Pregunta:";
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(81, 136);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(60, 23);
            this.btnIngresarDatos.TabIndex = 19;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(274, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(210, 136);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 23);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(146, 136);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxIdPregunta
            // 
            this.cbxIdPregunta.FormattingEnabled = true;
            this.cbxIdPregunta.Location = new System.Drawing.Point(146, 92);
            this.cbxIdPregunta.Name = "cbxIdPregunta";
            this.cbxIdPregunta.Size = new System.Drawing.Size(250, 21);
            this.cbxIdPregunta.TabIndex = 36;
            this.cbxIdPregunta.SelectedIndexChanged += new System.EventHandler(this.cbxIdPregunta_SelectedIndexChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(146, 53);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(250, 21);
            this.cbxCategoria.TabIndex = 38;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(10, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.Text = "Categoría:";
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 187);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxIdPregunta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.lblIdPregunta);
            this.Controls.Add(this.txtIdEvaluacion);
            this.Controls.Add(this.lblIdEvaluacion);
            this.Name = "frmEvaluacion";
            this.Text = "frmEvaluacion";
            this.Load += new System.EventHandler(this.frmEvaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdEvaluacion;
        private System.Windows.Forms.Label lblIdEvaluacion;
        private System.Windows.Forms.Label lblIdPregunta;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxIdPregunta;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
    }
}