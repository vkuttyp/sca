﻿namespace asistencia
{
    partial class frmLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicencia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calend_CalendarioDiasConPermisos = new ClaseCalendario.Calendario();
            this.btnGrupales = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumeroDocumento);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(322, 41);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "N° documento";
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.tbNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDocumento.Location = new System.Drawing.Point(86, 61);
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Size = new System.Drawing.Size(226, 20);
            this.tbNumeroDocumento.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(191, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Brown;
            this.lbNombre.Location = new System.Drawing.Point(89, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 15);
            this.lbNombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empleado";
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.White;
            this.tbDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(86, 11);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 0;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNI_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI";
            // 
            // calend_CalendarioDiasConPermisos
            // 
            this.calend_CalendarioDiasConPermisos.AutoSize = true;
            this.calend_CalendarioDiasConPermisos.BackColor = System.Drawing.Color.DodgerBlue;
            this.calend_CalendarioDiasConPermisos.BackColorMonthYearValue = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasConPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calend_CalendarioDiasConPermisos.ColorTextoDia = System.Drawing.SystemColors.ControlDark;
            this.calend_CalendarioDiasConPermisos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calend_CalendarioDiasConPermisos.DiasMesConOpciones = new string[] {
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.calend_CalendarioDiasConPermisos.Enabled = false;
            this.calend_CalendarioDiasConPermisos.FechaActualHoy = new System.DateTime(((long)(0)));
            this.calend_CalendarioDiasConPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calend_CalendarioDiasConPermisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ((System.Collections.ArrayList)(resources.GetObject("calend_CalendarioDiasConPermisos.ListaOpcionesFeriados")));
            this.calend_CalendarioDiasConPermisos.Location = new System.Drawing.Point(7, 88);
            this.calend_CalendarioDiasConPermisos.MaximumSize = new System.Drawing.Size(900, 831);
            this.calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] {
        3,
        2011};
            this.calend_CalendarioDiasConPermisos.MinimumSize = new System.Drawing.Size(423, 383);
            this.calend_CalendarioDiasConPermisos.Name = "calend_CalendarioDiasConPermisos";
            this.calend_CalendarioDiasConPermisos.Size = new System.Drawing.Size(427, 384);
            this.calend_CalendarioDiasConPermisos.TabIndex = 2;
            // 
            // btnGrupales
            // 
            this.btnGrupales.BackColor = System.Drawing.Color.Red;
            this.btnGrupales.ForeColor = System.Drawing.Color.White;
            this.btnGrupales.Location = new System.Drawing.Point(79, 477);
            this.btnGrupales.Name = "btnGrupales";
            this.btnGrupales.Size = new System.Drawing.Size(299, 23);
            this.btnGrupales.TabIndex = 8;
            this.btnGrupales.Text = "ASIGNAR LICENCIAS GRUPALES";
            this.btnGrupales.UseVisualStyleBackColor = false;
            this.btnGrupales.Click += new System.EventHandler(this.btnGrupales_Click);
            // 
            // frmLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 506);
            this.Controls.Add(this.btnGrupales);
            this.Controls.Add(this.calend_CalendarioDiasConPermisos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE LICENCIAS INDIVIDUALES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroDocumento;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label5;
        private ClaseCalendario.Calendario calend_CalendarioDiasConPermisos;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGrupales;
    }
}