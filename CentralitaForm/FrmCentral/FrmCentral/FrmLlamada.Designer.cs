namespace FrmCentral
{
    partial class FrmLlamada
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
            this.cmbTipoLlamada = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoLlamada
            // 
            this.cmbTipoLlamada.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoLlamada.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbTipoLlamada.FormattingEnabled = true;
            this.cmbTipoLlamada.Items.AddRange(new object[] {
            "Local",
            "Provincial"});
            this.cmbTipoLlamada.Location = new System.Drawing.Point(13, 13);
            this.cmbTipoLlamada.Name = "cmbTipoLlamada";
            this.cmbTipoLlamada.Size = new System.Drawing.Size(182, 24);
            this.cmbTipoLlamada.TabIndex = 0;
            this.cmbTipoLlamada.Text = "Seleccione tipo llamada";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDuracion.Location = new System.Drawing.Point(84, 44);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(111, 23);
            this.txtDuracion.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDestino.Location = new System.Drawing.Point(84, 73);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(111, 23);
            this.txtDestino.TabIndex = 2;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtOrigen.Location = new System.Drawing.Point(84, 102);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(111, 23);
            this.txtOrigen.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(13, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(112, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(10, 47);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(65, 17);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(10, 79);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 17);
            this.lblDestino.TabIndex = 7;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(10, 108);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(51, 17);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // FrmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 177);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.cmbTipoLlamada);
            this.Name = "FrmLlamada";
            this.Text = "FrmLlamada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoLlamada;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
    }
}