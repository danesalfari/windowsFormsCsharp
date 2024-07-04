namespace EvaluacionC_.View
{
    partial class frmPrueba
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
            this.lblIdPrueba = new System.Windows.Forms.Label();
            this.lblIdAprendiz = new System.Windows.Forms.Label();
            this.lblIdEvaluacion = new System.Windows.Forms.Label();
            this.txtIdPrueba = new System.Windows.Forms.TextBox();
            this.btnEmpezarPrueba = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxIdEvaluacion = new System.Windows.Forms.ComboBox();
            this.cbxIdAprendiz = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdPrueba
            // 
            this.lblIdPrueba.AutoSize = true;
            this.lblIdPrueba.Location = new System.Drawing.Point(12, 19);
            this.lblIdPrueba.Name = "lblIdPrueba";
            this.lblIdPrueba.Size = new System.Drawing.Size(56, 13);
            this.lblIdPrueba.TabIndex = 5;
            this.lblIdPrueba.Text = "Id Prueba:";
            // 
            // lblIdAprendiz
            // 
            this.lblIdAprendiz.AutoSize = true;
            this.lblIdAprendiz.Location = new System.Drawing.Point(12, 92);
            this.lblIdAprendiz.Name = "lblIdAprendiz";
            this.lblIdAprendiz.Size = new System.Drawing.Size(63, 13);
            this.lblIdAprendiz.TabIndex = 4;
            this.lblIdAprendiz.Text = "Id Aprendiz:";
            // 
            // lblIdEvaluacion
            // 
            this.lblIdEvaluacion.AutoSize = true;
            this.lblIdEvaluacion.Location = new System.Drawing.Point(12, 53);
            this.lblIdEvaluacion.Name = "lblIdEvaluacion";
            this.lblIdEvaluacion.Size = new System.Drawing.Size(75, 13);
            this.lblIdEvaluacion.TabIndex = 3;
            this.lblIdEvaluacion.Text = "Id Evaluación:";
            // 
            // txtIdPrueba
            // 
            this.txtIdPrueba.Location = new System.Drawing.Point(150, 12);
            this.txtIdPrueba.Name = "txtIdPrueba";
            this.txtIdPrueba.Size = new System.Drawing.Size(250, 20);
            this.txtIdPrueba.TabIndex = 12;
            // 
            // btnEmpezarPrueba
            // 
            this.btnEmpezarPrueba.Location = new System.Drawing.Point(80, 136);
            this.btnEmpezarPrueba.Name = "btnEmpezarPrueba";
            this.btnEmpezarPrueba.Size = new System.Drawing.Size(106, 23);
            this.btnEmpezarPrueba.TabIndex = 18;
            this.btnEmpezarPrueba.Text = "Empezar Prueba";
            this.btnEmpezarPrueba.UseVisualStyleBackColor = true;
            this.btnEmpezarPrueba.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(301, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(191, 136);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxIdEvaluacion
            // 
            this.cbxIdEvaluacion.FormattingEnabled = true;
            this.cbxIdEvaluacion.Location = new System.Drawing.Point(150, 50);
            this.cbxIdEvaluacion.Name = "cbxIdEvaluacion";
            this.cbxIdEvaluacion.Size = new System.Drawing.Size(250, 21);
            this.cbxIdEvaluacion.TabIndex = 24;
            this.cbxIdEvaluacion.SelectedIndexChanged += new System.EventHandler(this.cbxIdEvaluacion_SelectedIndexChanged);
            // 
            // cbxIdAprendiz
            // 
            this.cbxIdAprendiz.FormattingEnabled = true;
            this.cbxIdAprendiz.Location = new System.Drawing.Point(150, 84);
            this.cbxIdAprendiz.Name = "cbxIdAprendiz";
            this.cbxIdAprendiz.Size = new System.Drawing.Size(250, 21);
            this.cbxIdAprendiz.TabIndex = 25;
            this.cbxIdAprendiz.SelectedIndexChanged += new System.EventHandler(this.cbxIdAprendiz_SelectedIndexChanged);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 170);
            this.Controls.Add(this.cbxIdAprendiz);
            this.Controls.Add(this.cbxIdEvaluacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEmpezarPrueba);
            this.Controls.Add(this.txtIdPrueba);
            this.Controls.Add(this.lblIdPrueba);
            this.Controls.Add(this.lblIdAprendiz);
            this.Controls.Add(this.lblIdEvaluacion);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPrueba;
        private System.Windows.Forms.Label lblIdAprendiz;
        private System.Windows.Forms.Label lblIdEvaluacion;
        private System.Windows.Forms.TextBox txtIdPrueba;
        private System.Windows.Forms.Button btnEmpezarPrueba;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxIdEvaluacion;
        private System.Windows.Forms.ComboBox cbxIdAprendiz;
    }
}