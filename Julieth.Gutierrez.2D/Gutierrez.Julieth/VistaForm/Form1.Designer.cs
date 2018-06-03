namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(217, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(9, 202);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(94, 43);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(167, 204);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 41);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(103, 145);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 24);
            this.cmbDivision.TabIndex = 3;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(90, 56);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbDivisionCurso.TabIndex = 4;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(90, 170);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 5;
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.lblAnioCurso);
            this.gpbDatosAlumno.Controls.Add(this.nudAnioCurso);
            this.gpbDatosAlumno.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosAlumno.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosAlumno.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosAlumno.Controls.Add(this.lblFechaIngreso);
            this.gpbDatosAlumno.Controls.Add(this.lblNombreProfe);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosAlumno.Controls.Add(this.txtNombreProfe);
            this.gpbDatosAlumno.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosAlumno.Controls.Add(this.lblDocumentoProfe);
            this.gpbDatosAlumno.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosAlumno.Controls.Add(this.btnCrear);
            this.gpbDatosAlumno.Controls.Add(this.btnMostrar);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(310, 251);
            this.gpbDatosAlumno.TabIndex = 6;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Curso";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(6, 28);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(33, 17);
            this.lblAnioCurso.TabIndex = 9;
            this.lblAnioCurso.Text = "Año";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(91, 28);
            this.nudAnioCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(120, 22);
            this.nudAnioCurso.TabIndex = 19;
            this.nudAnioCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(90, 142);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(200, 22);
            this.txtDocumentoProfe.TabIndex = 24;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(90, 114);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(200, 22);
            this.txtApellidoProfe.TabIndex = 25;
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(6, 59);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(57, 17);
            this.lblDivisionCurso.TabIndex = 13;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(6, 175);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(55, 17);
            this.lblFechaIngreso.TabIndex = 16;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(6, 89);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(58, 17);
            this.lblNombreProfe.TabIndex = 18;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(90, 86);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(200, 22);
            this.txtNombreProfe.TabIndex = 22;
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(6, 117);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(58, 17);
            this.lblApellidoProfe.TabIndex = 10;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(6, 145);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(31, 17);
            this.lblDocumentoProfe.TabIndex = 15;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.txtDocumento);
            this.gpbDatosCurso.Controls.Add(this.lblDivision);
            this.gpbDatosCurso.Controls.Add(this.nudAnio);
            this.gpbDatosCurso.Controls.Add(this.cmbDivision);
            this.gpbDatosCurso.Controls.Add(this.txtApellido);
            this.gpbDatosCurso.Controls.Add(this.txtNombre);
            this.gpbDatosCurso.Controls.Add(this.lblAnio);
            this.gpbDatosCurso.Controls.Add(this.lblApellido);
            this.gpbDatosCurso.Controls.Add(this.btnAgregar);
            this.gpbDatosCurso.Controls.Add(this.lblNombre);
            this.gpbDatosCurso.Controls.Add(this.lblDocumento);
            this.gpbDatosCurso.Location = new System.Drawing.Point(328, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(310, 251);
            this.gpbDatosCurso.TabIndex = 7;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Alumno";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(104, 89);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 22);
            this.txtDocumento.TabIndex = 26;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 145);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(57, 17);
            this.lblDivision.TabIndex = 12;
            this.lblDivision.Text = "Division";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(104, 117);
            this.nudAnio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 22);
            this.nudAnio.TabIndex = 20;
            this.nudAnio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 22);
            this.txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 23;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(6, 117);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 17);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 89);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(51, 17);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Legajo";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(-2, 269);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(652, 180);
            this.rtbDatos.TabIndex = 21;
            this.rtbDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDatosCurso);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
    }
}

