namespace TP10
{
    partial class Form1
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
            this.txtDay = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.NumericUpDown();
            this.txtDNIdisponibles = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlumnoGuardar = new System.Windows.Forms.Button();
            this.btnNotaGuardar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.NumericUpDown();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridNota = new System.Windows.Forms.DataGridView();
            this.gridAlumno = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.gridPromedio = new System.Windows.Forms.DataGridView();
            this.btnOrdenarAlumnos = new System.Windows.Forms.Button();
            this.btnOrdenarNotas = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPromediar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNIdisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(94, 359);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(200, 22);
            this.txtDay.TabIndex = 64;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(126, 315);
            this.txtNote.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(168, 22);
            this.txtNote.TabIndex = 63;
            // 
            // txtDNIdisponibles
            // 
            this.txtDNIdisponibles.Location = new System.Drawing.Point(126, 270);
            this.txtDNIdisponibles.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtDNIdisponibles.Name = "txtDNIdisponibles";
            this.txtDNIdisponibles.Size = new System.Drawing.Size(168, 22);
            this.txtDNIdisponibles.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 61;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "DNI";
            // 
            // btnAlumnoGuardar
            // 
            this.btnAlumnoGuardar.BackColor = System.Drawing.Color.White;
            this.btnAlumnoGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlumnoGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlumnoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnoGuardar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnoGuardar.Location = new System.Drawing.Point(35, 175);
            this.btnAlumnoGuardar.Name = "btnAlumnoGuardar";
            this.btnAlumnoGuardar.Size = new System.Drawing.Size(118, 32);
            this.btnAlumnoGuardar.TabIndex = 58;
            this.btnAlumnoGuardar.Text = "Guardar";
            this.btnAlumnoGuardar.UseVisualStyleBackColor = false;
            this.btnAlumnoGuardar.Click += new System.EventHandler(this.btnAlumnoGuardar_Click);
            // 
            // btnNotaGuardar
            // 
            this.btnNotaGuardar.BackColor = System.Drawing.Color.White;
            this.btnNotaGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotaGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNotaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaGuardar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaGuardar.Location = new System.Drawing.Point(35, 406);
            this.btnNotaGuardar.Name = "btnNotaGuardar";
            this.btnNotaGuardar.Size = new System.Drawing.Size(118, 32);
            this.btnNotaGuardar.TabIndex = 57;
            this.btnNotaGuardar.Text = "Guardar";
            this.btnNotaGuardar.UseVisualStyleBackColor = false;
            this.btnNotaGuardar.Click += new System.EventHandler(this.btnNotaGuardar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(126, 29);
            this.txtDNI.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(168, 22);
            this.txtDNI.TabIndex = 56;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(126, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 22);
            this.txtApellido.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 22);
            this.txtNombre.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "DNI";
            // 
            // gridNota
            // 
            this.gridNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNota.Location = new System.Drawing.Point(330, 269);
            this.gridNota.Name = "gridNota";
            this.gridNota.RowHeadersWidth = 51;
            this.gridNota.RowTemplate.Height = 24;
            this.gridNota.Size = new System.Drawing.Size(430, 169);
            this.gridNota.TabIndex = 50;
            // 
            // gridAlumno
            // 
            this.gridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumno.Location = new System.Drawing.Point(330, 28);
            this.gridAlumno.Name = "gridAlumno";
            this.gridAlumno.RowHeadersWidth = 51;
            this.gridAlumno.RowTemplate.Height = 24;
            this.gridAlumno.Size = new System.Drawing.Size(430, 179);
            this.gridAlumno.TabIndex = 49;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(423, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 32);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(1000, 28);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(133, 31);
            this.lblPromedio.TabIndex = 68;
            this.lblPromedio.Text = "Promedio";
            // 
            // gridPromedio
            // 
            this.gridPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromedio.Location = new System.Drawing.Point(802, 69);
            this.gridPromedio.Name = "gridPromedio";
            this.gridPromedio.RowHeadersWidth = 51;
            this.gridPromedio.RowTemplate.Height = 24;
            this.gridPromedio.Size = new System.Drawing.Size(508, 369);
            this.gridPromedio.TabIndex = 69;
            // 
            // btnOrdenarAlumnos
            // 
            this.btnOrdenarAlumnos.BackColor = System.Drawing.Color.White;
            this.btnOrdenarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOrdenarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarAlumnos.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarAlumnos.Location = new System.Drawing.Point(159, 175);
            this.btnOrdenarAlumnos.Name = "btnOrdenarAlumnos";
            this.btnOrdenarAlumnos.Size = new System.Drawing.Size(118, 32);
            this.btnOrdenarAlumnos.TabIndex = 70;
            this.btnOrdenarAlumnos.Text = "Ordenar";
            this.btnOrdenarAlumnos.UseVisualStyleBackColor = false;
            this.btnOrdenarAlumnos.Click += new System.EventHandler(this.btnOrdenarAlumnos_Click);
            // 
            // btnOrdenarNotas
            // 
            this.btnOrdenarNotas.BackColor = System.Drawing.Color.White;
            this.btnOrdenarNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOrdenarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarNotas.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarNotas.Location = new System.Drawing.Point(159, 406);
            this.btnOrdenarNotas.Name = "btnOrdenarNotas";
            this.btnOrdenarNotas.Size = new System.Drawing.Size(118, 32);
            this.btnOrdenarNotas.TabIndex = 71;
            this.btnOrdenarNotas.Text = "Ordenar";
            this.btnOrdenarNotas.UseVisualStyleBackColor = false;
            this.btnOrdenarNotas.Click += new System.EventHandler(this.btnOrdenarNotas_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(569, 461);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 32);
            this.btnBorrar.TabIndex = 72;
            this.btnBorrar.Text = "BORRAR TODO";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.BackColor = System.Drawing.Color.White;
            this.btnPromediar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPromediar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPromediar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromediar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromediar.Location = new System.Drawing.Point(1006, 461);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(127, 32);
            this.btnPromediar.TabIndex = 73;
            this.btnPromediar.Text = "Promediar";
            this.btnPromediar.UseVisualStyleBackColor = false;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 512);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOrdenarNotas);
            this.Controls.Add(this.btnOrdenarAlumnos);
            this.Controls.Add(this.gridPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDNIdisponibles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlumnoGuardar);
            this.Controls.Add(this.btnNotaGuardar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridNota);
            this.Controls.Add(this.gridAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNIdisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDay;
        private System.Windows.Forms.NumericUpDown txtNote;
        private System.Windows.Forms.NumericUpDown txtDNIdisponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlumnoGuardar;
        private System.Windows.Forms.Button btnNotaGuardar;
        private System.Windows.Forms.NumericUpDown txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridNota;
        private System.Windows.Forms.DataGridView gridAlumno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridView gridPromedio;
        private System.Windows.Forms.Button btnOrdenarAlumnos;
        private System.Windows.Forms.Button btnOrdenarNotas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPromediar;
    }
}

