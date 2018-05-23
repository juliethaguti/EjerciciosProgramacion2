namespace FrmCentral
{
    partial class FrmCentralita
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
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRazonSocial.Location = new System.Drawing.Point(13, 13);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(257, 23);
            this.txtRazonSocial.TabIndex = 0;
            this.txtRazonSocial.Text = "Nombre de la empresa";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Local",
            "Provincial",
            "Todas"});
            this.cmbTipo.Location = new System.Drawing.Point(13, 256);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(134, 24);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.Text = "Seleccione Tipo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(506, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 31);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(506, 191);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 31);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancias.Location = new System.Drawing.Point(10, 235);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(48, 18);
            this.lblGanancias.TabIndex = 5;
            this.lblGanancias.Text = "label1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(506, 235);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 180);
            this.listBox1.TabIndex = 7;
            // 
            // FrmCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 297);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtRazonSocial);
            this.Name = "FrmCentralita";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCentralita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox listBox1;
    }
}

