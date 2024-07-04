namespace EvaluacionC_.View
{
    partial class frmPreguntas
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTextoPregunta = new System.Windows.Forms.TextBox();
            this.lblTextoPregunta = new System.Windows.Forms.Label();
            this.lblIdTipoPregunta = new System.Windows.Forms.Label();
            this.txtIdPregunta = new System.Windows.Forms.TextBox();
            this.lblIdPregunta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.cbxIdTipoPregunta = new System.Windows.Forms.ComboBox();
            this.cbxIdCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 107);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Id Categoría:";
            // 
            // txtTextoPregunta
            // 
            this.txtTextoPregunta.Location = new System.Drawing.Point(152, 145);
            this.txtTextoPregunta.Name = "txtTextoPregunta";
            this.txtTextoPregunta.Size = new System.Drawing.Size(250, 20);
            this.txtTextoPregunta.TabIndex = 34;
            // 
            // lblTextoPregunta
            // 
            this.lblTextoPregunta.AutoSize = true;
            this.lblTextoPregunta.Location = new System.Drawing.Point(15, 152);
            this.lblTextoPregunta.Name = "lblTextoPregunta";
            this.lblTextoPregunta.Size = new System.Drawing.Size(83, 13);
            this.lblTextoPregunta.TabIndex = 33;
            this.lblTextoPregunta.Text = "Texto Pregunta:";
            // 
            // lblIdTipoPregunta
            // 
            this.lblIdTipoPregunta.AutoSize = true;
            this.lblIdTipoPregunta.Location = new System.Drawing.Point(16, 64);
            this.lblIdTipoPregunta.Name = "lblIdTipoPregunta";
            this.lblIdTipoPregunta.Size = new System.Drawing.Size(89, 13);
            this.lblIdTipoPregunta.TabIndex = 31;
            this.lblIdTipoPregunta.Text = "Id Tipo Pregunta:";
            // 
            // txtIdPregunta
            // 
            this.txtIdPregunta.Location = new System.Drawing.Point(152, 12);
            this.txtIdPregunta.Name = "txtIdPregunta";
            this.txtIdPregunta.Size = new System.Drawing.Size(250, 20);
            this.txtIdPregunta.TabIndex = 29;
            // 
            // lblIdPregunta
            // 
            this.lblIdPregunta.AutoSize = true;
            this.lblIdPregunta.Location = new System.Drawing.Point(16, 19);
            this.lblIdPregunta.Name = "lblIdPregunta";
            this.lblIdPregunta.Size = new System.Drawing.Size(65, 13);
            this.lblIdPregunta.TabIndex = 28;
            this.lblIdPregunta.Text = "Id Pregunta:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(284, 193);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(220, 193);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 23);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(156, 193);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(91, 193);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(60, 23);
            this.btnIngresarDatos.TabIndex = 37;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // cbxIdTipoPregunta
            // 
            this.cbxIdTipoPregunta.FormattingEnabled = true;
            this.cbxIdTipoPregunta.Location = new System.Drawing.Point(152, 56);
            this.cbxIdTipoPregunta.Name = "cbxIdTipoPregunta";
            this.cbxIdTipoPregunta.Size = new System.Drawing.Size(250, 21);
            this.cbxIdTipoPregunta.TabIndex = 41;
            this.cbxIdTipoPregunta.SelectedIndexChanged += new System.EventHandler(this.cbxIdTipoPregunta_SelectedIndexChanged);
            // 
            // cbxIdCategoria
            // 
            this.cbxIdCategoria.FormattingEnabled = true;
            this.cbxIdCategoria.Location = new System.Drawing.Point(152, 99);
            this.cbxIdCategoria.Name = "cbxIdCategoria";
            this.cbxIdCategoria.Size = new System.Drawing.Size(250, 21);
            this.cbxIdCategoria.TabIndex = 42;
            this.cbxIdCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxIdCategoria_SelectedIndexChanged);
            // 
            // frmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 228);
            this.Controls.Add(this.cbxIdCategoria);
            this.Controls.Add(this.cbxIdTipoPregunta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtTextoPregunta);
            this.Controls.Add(this.lblTextoPregunta);
            this.Controls.Add(this.lblIdTipoPregunta);
            this.Controls.Add(this.txtIdPregunta);
            this.Controls.Add(this.lblIdPregunta);
            this.Name = "frmPreguntas";
            this.Text = "frmPreguntas";
            this.Load += new System.EventHandler(this.frmPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtTextoPregunta;
        private System.Windows.Forms.Label lblTextoPregunta;
        private System.Windows.Forms.Label lblIdTipoPregunta;
        private System.Windows.Forms.TextBox txtIdPregunta;
        private System.Windows.Forms.Label lblIdPregunta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.ComboBox cbxIdTipoPregunta;
        private System.Windows.Forms.ComboBox cbxIdCategoria;
    }
}