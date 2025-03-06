namespace GestionHospital
{
    partial class FormPaciente
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
            this.comboBuscador = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSintomas = new System.Windows.Forms.TextBox();
            this.comboMedicName = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.listCitas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBuscador
            // 
            this.comboBuscador.FormattingEnabled = true;
            this.comboBuscador.Location = new System.Drawing.Point(12, 37);
            this.comboBuscador.Name = "comboBuscador";
            this.comboBuscador.Size = new System.Drawing.Size(266, 24);
            this.comboBuscador.TabIndex = 0;
            this.comboBuscador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Medico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sintomas";
            // 
            // textSintomas
            // 
            this.textSintomas.Enabled = false;
            this.textSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSintomas.Location = new System.Drawing.Point(645, 166);
            this.textSintomas.Multiline = true;
            this.textSintomas.Name = "textSintomas";
            this.textSintomas.Size = new System.Drawing.Size(429, 171);
            this.textSintomas.TabIndex = 11;
            // 
            // comboMedicName
            // 
            this.comboMedicName.Enabled = false;
            this.comboMedicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMedicName.FormattingEnabled = true;
            this.comboMedicName.Location = new System.Drawing.Point(398, 237);
            this.comboMedicName.Name = "comboMedicName";
            this.comboMedicName.Size = new System.Drawing.Size(182, 33);
            this.comboMedicName.TabIndex = 12;
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(96, 120);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(182, 30);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(96, 175);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 30);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(96, 240);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 30);
            this.txtApellido.TabIndex = 15;
            // 
            // listCitas
            // 
            this.listCitas.FormattingEnabled = true;
            this.listCitas.ItemHeight = 16;
            this.listCitas.Location = new System.Drawing.Point(14, 406);
            this.listCitas.Name = "listCitas";
            this.listCitas.Size = new System.Drawing.Size(1031, 148);
            this.listCitas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Citas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Notas";
            // 
            // txtNotas
            // 
            this.txtNotas.Enabled = false;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(12, 595);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(1033, 121);
            this.txtNotas.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(961, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "Crear cita";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(867, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 32);
            this.button5.TabIndex = 22;
            this.button5.Text = "Borrar cita";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(398, 182);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 22);
            this.numEdad.TabIndex = 25;
            // 
            // numTelefono
            // 
            this.numTelefono.InterceptArrowKeys = false;
            this.numTelefono.Location = new System.Drawing.Point(398, 125);
            this.numTelefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Size = new System.Drawing.Size(159, 22);
            this.numTelefono.TabIndex = 26;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 739);
            this.Controls.Add(this.numTelefono);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCitas);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.comboMedicName);
            this.Controls.Add(this.textSintomas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBuscador);
            this.Name = "FormPaciente";
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.FormPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBuscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSintomas;
        private System.Windows.Forms.ComboBox comboMedicName;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ListBox listCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numTelefono;
    }
}