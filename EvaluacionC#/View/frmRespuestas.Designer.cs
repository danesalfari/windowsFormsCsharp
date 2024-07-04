namespace EvaluacionC_.View
{
    partial class frmRespuestas
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
            this.lblIdPregunta = new System.Windows.Forms.Label();
            this.txtIdRespuesta = new System.Windows.Forms.TextBox();
            this.lblIdRespuesta = new System.Windows.Forms.Label();
            this.lblTextoRespuesta = new System.Windows.Forms.Label();
            this.txtRespuestaValida = new System.Windows.Forms.TextBox();
            this.lblRespuestaValida = new System.Windows.Forms.Label();
            this.txtTextoRespuesta = new System.Windows.Forms.TextBox();
            this.cbxIdPregunta = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdPregunta
            // 
            this.lblIdPregunta.AutoSize = true;
            this.lblIdPregunta.Location = new System.Drawing.Point(13, 59);
            this.lblIdPregunta.Name = "lblIdPregunta";
            this.lblIdPregunta.Size = new System.Drawing.Size(65, 13);
            this.lblIdPregunta.TabIndex = 19;
            this.lblIdPregunta.Text = "Id Pregunta:";
            // 
            // txtIdRespuesta
            // 
            this.txtIdRespuesta.Location = new System.Drawing.Point(149, 12);
            this.txtIdRespuesta.Name = "txtIdRespuesta";
            this.txtIdRespuesta.Size = new System.Drawing.Size(250, 20);
            this.txtIdRespuesta.TabIndex = 23;
            // 
            // lblIdRespuesta
            // 
            this.lblIdRespuesta.AutoSize = true;
            this.lblIdRespuesta.Location = new System.Drawing.Point(13, 19);
            this.lblIdRespuesta.Name = "lblIdRespuesta";
            this.lblIdRespuesta.Size = new System.Drawing.Size(73, 13);
            this.lblIdRespuesta.TabIndex = 22;
            this.lblIdRespuesta.Text = "Id Respuesta:";
            // 
            // lblTextoRespuesta
            // 
            this.lblTextoRespuesta.AutoSize = true;
            this.lblTextoRespuesta.Location = new System.Drawing.Point(12, 107);
            this.lblTextoRespuesta.Name = "lblTextoRespuesta";
            this.lblTextoRespuesta.Size = new System.Drawing.Size(91, 13);
            this.lblTextoRespuesta.TabIndex = 24;
            this.lblTextoRespuesta.Text = "Texto Respuesta:";
            // 
            // txtRespuestaValida
            // 
            this.txtRespuestaValida.Location = new System.Drawing.Point(149, 150);
            this.txtRespuestaValida.Name = "txtRespuestaValida";
            this.txtRespuestaValida.Size = new System.Drawing.Size(250, 20);
            this.txtRespuestaValida.TabIndex = 27;
            // 
            // lblRespuestaValida
            // 
            this.lblRespuestaValida.AutoSize = true;
            this.lblRespuestaValida.Location = new System.Drawing.Point(12, 157);
            this.lblRespuestaValida.Name = "lblRespuestaValida";
            this.lblRespuestaValida.Size = new System.Drawing.Size(93, 13);
            this.lblRespuestaValida.TabIndex = 26;
            this.lblRespuestaValida.Text = "Respuesta Válida:";
            // 
            // txtTextoRespuesta
            // 
            this.txtTextoRespuesta.Location = new System.Drawing.Point(149, 100);
            this.txtTextoRespuesta.Name = "txtTextoRespuesta";
            this.txtTextoRespuesta.Size = new System.Drawing.Size(250, 20);
            this.txtTextoRespuesta.TabIndex = 25;
            // 
            // cbxIdPregunta
            // 
            this.cbxIdPregunta.FormattingEnabled = true;
            this.cbxIdPregunta.Location = new System.Drawing.Point(149, 56);
            this.cbxIdPregunta.Name = "cbxIdPregunta";
            this.cbxIdPregunta.Size = new System.Drawing.Size(250, 21);
            this.cbxIdPregunta.TabIndex = 37;
            this.cbxIdPregunta.SelectedIndexChanged += new System.EventHandler(this.cbxIdPregunta_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 197);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(206, 197);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 23);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(142, 197);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(77, 197);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(60, 23);
            this.btnIngresarDatos.TabIndex = 41;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // frmRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 231);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.cbxIdPregunta);
            this.Controls.Add(this.txtRespuestaValida);
            this.Controls.Add(this.lblRespuestaValida);
            this.Controls.Add(this.txtTextoRespuesta);
            this.Controls.Add(this.lblTextoRespuesta);
            this.Controls.Add(this.txtIdRespuesta);
            this.Controls.Add(this.lblIdRespuesta);
            this.Controls.Add(this.lblIdPregunta);
            this.Name = "frmRespuestas";
            this.Text = "frmRespuestas";
            this.Load += new System.EventHandler(this.frmRespuestas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdPregunta;
        private System.Windows.Forms.TextBox txtIdRespuesta;
        private System.Windows.Forms.Label lblIdRespuesta;
        private System.Windows.Forms.Label lblTextoRespuesta;
        private System.Windows.Forms.TextBox txtRespuestaValida;
        private System.Windows.Forms.Label lblRespuestaValida;
        private System.Windows.Forms.TextBox txtTextoRespuesta;
        private System.Windows.Forms.ComboBox cbxIdPregunta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIngresarDatos;
    }
}