namespace EvaluacionC_.View
{
    partial class frmAprendiz
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
            this.lblDocumentoAprendiz = new System.Windows.Forms.Label();
            this.lblIdAprendiz = new System.Windows.Forms.Label();
            this.lblNombreAprendiz = new System.Windows.Forms.Label();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.txtIdAprendiz = new System.Windows.Forms.TextBox();
            this.txtNombreAprendiz = new System.Windows.Forms.TextBox();
            this.txtDocumentoAprendiz = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocumentoAprendiz
            // 
            this.lblDocumentoAprendiz.AutoSize = true;
            this.lblDocumentoAprendiz.Location = new System.Drawing.Point(12, 49);
            this.lblDocumentoAprendiz.Name = "lblDocumentoAprendiz";
            this.lblDocumentoAprendiz.Size = new System.Drawing.Size(109, 13);
            this.lblDocumentoAprendiz.TabIndex = 0;
            this.lblDocumentoAprendiz.Text = "Documento Aprendiz:";
            // 
            // lblIdAprendiz
            // 
            this.lblIdAprendiz.AutoSize = true;
            this.lblIdAprendiz.Location = new System.Drawing.Point(12, 13);
            this.lblIdAprendiz.Name = "lblIdAprendiz";
            this.lblIdAprendiz.Size = new System.Drawing.Size(63, 13);
            this.lblIdAprendiz.TabIndex = 1;
            this.lblIdAprendiz.Text = "Id Aprendiz:";
            // 
            // lblNombreAprendiz
            // 
            this.lblNombreAprendiz.AutoSize = true;
            this.lblNombreAprendiz.Location = new System.Drawing.Point(12, 88);
            this.lblNombreAprendiz.Name = "lblNombreAprendiz";
            this.lblNombreAprendiz.Size = new System.Drawing.Size(91, 13);
            this.lblNombreAprendiz.TabIndex = 2;
            this.lblNombreAprendiz.Text = "Nombre Aprendiz:";
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(78, 131);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(60, 23);
            this.btnIngresarDatos.TabIndex = 3;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // txtIdAprendiz
            // 
            this.txtIdAprendiz.Location = new System.Drawing.Point(142, 6);
            this.txtIdAprendiz.Name = "txtIdAprendiz";
            this.txtIdAprendiz.Size = new System.Drawing.Size(250, 20);
            this.txtIdAprendiz.TabIndex = 9;
            // 
            // txtNombreAprendiz
            // 
            this.txtNombreAprendiz.Location = new System.Drawing.Point(142, 85);
            this.txtNombreAprendiz.Name = "txtNombreAprendiz";
            this.txtNombreAprendiz.Size = new System.Drawing.Size(250, 20);
            this.txtNombreAprendiz.TabIndex = 10;
            // 
            // txtDocumentoAprendiz
            // 
            this.txtDocumentoAprendiz.Location = new System.Drawing.Point(142, 46);
            this.txtDocumentoAprendiz.Name = "txtDocumentoAprendiz";
            this.txtDocumentoAprendiz.Size = new System.Drawing.Size(250, 20);
            this.txtDocumentoAprendiz.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 131);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(207, 131);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(143, 131);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 165);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDocumentoAprendiz);
            this.Controls.Add(this.txtNombreAprendiz);
            this.Controls.Add(this.txtIdAprendiz);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.lblNombreAprendiz);
            this.Controls.Add(this.lblIdAprendiz);
            this.Controls.Add(this.lblDocumentoAprendiz);
            this.Name = "frmAprendiz";
            this.Text = "frmAprendiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumentoAprendiz;
        private System.Windows.Forms.Label lblIdAprendiz;
        private System.Windows.Forms.Label lblNombreAprendiz;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.TextBox txtIdAprendiz;
        private System.Windows.Forms.TextBox txtNombreAprendiz;
        private System.Windows.Forms.TextBox txtDocumentoAprendiz;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
    }
}