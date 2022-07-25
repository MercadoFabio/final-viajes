
namespace ViajesFinal
{
    partial class frmViajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstViajes = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSaalir = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transporte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(184, 74);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(184, 104);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(124, 20);
            this.txtDestino.TabIndex = 6;
            // 
            // cboTransporte
            // 
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(184, 132);
            this.cboTransporte.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(124, 21);
            this.cboTransporte.TabIndex = 7;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbInternacional);
            this.gbTipo.Controls.Add(this.rbNacional);
            this.gbTipo.Location = new System.Drawing.Point(102, 157);
            this.gbTipo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbTipo.Size = new System.Drawing.Size(222, 36);
            this.gbTipo.TabIndex = 8;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo Destino";
            // 
            // rbInternacional
            // 
            this.rbInternacional.AutoSize = true;
            this.rbInternacional.Location = new System.Drawing.Point(123, 16);
            this.rbInternacional.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbInternacional.Name = "rbInternacional";
            this.rbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rbInternacional.TabIndex = 1;
            this.rbInternacional.TabStop = true;
            this.rbInternacional.Text = "Internacional";
            this.rbInternacional.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Location = new System.Drawing.Point(37, 16);
            this.rbNacional.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(67, 17);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(184, 198);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(124, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2022, 7, 13, 20, 15, 4, 0);
            // 
            // lstViajes
            // 
            this.lstViajes.FormattingEnabled = true;
            this.lstViajes.Location = new System.Drawing.Point(351, 47);
            this.lstViajes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lstViajes.Name = "lstViajes";
            this.lstViajes.Size = new System.Drawing.Size(165, 173);
            this.lstViajes.TabIndex = 10;
            this.lstViajes.SelectedIndexChanged += new System.EventHandler(this.lstViajes_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 229);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 21);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(88, 229);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 21);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(139, 266);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(55, 21);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(88, 266);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 21);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(196, 266);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 21);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSaalir
            // 
            this.btnSaalir.Location = new System.Drawing.Point(351, 264);
            this.btnSaalir.Name = "btnSaalir";
            this.btnSaalir.Size = new System.Drawing.Size(75, 23);
            this.btnSaalir.TabIndex = 17;
            this.btnSaalir.Text = "Salir";
            this.btnSaalir.UseVisualStyleBackColor = true;
            this.btnSaalir.Click += new System.EventHandler(this.btnSaalir_Click);
            // 
            // frmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 392);
            this.Controls.Add(this.btnSaalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstViajes);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.cboTransporte);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximumSize = new System.Drawing.Size(573, 431);
            this.MinimumSize = new System.Drawing.Size(573, 431);
            this.Name = "frmViajes";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmViajes_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbInternacional;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstViajes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSaalir;
    }
}

