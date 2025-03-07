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
            this.butCrear = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
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
            this.butCrearCita = new System.Windows.Forms.Button();
            this.butBorrarCita = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            this.butAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBuscador
            // 
            this.comboBuscador.FormattingEnabled = true;
            this.comboBuscador.Location = new System.Drawing.Point(9, 30);
            this.comboBuscador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBuscador.Name = "comboBuscador";
            this.comboBuscador.Size = new System.Drawing.Size(200, 21);
            this.comboBuscador.TabIndex = 0;
            this.comboBuscador.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // butCrear
            // 
            this.butCrear.Location = new System.Drawing.Point(226, 22);
            this.butCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCrear.Name = "butCrear";
            this.butCrear.Size = new System.Drawing.Size(58, 34);
            this.butCrear.TabIndex = 1;
            this.butCrear.Text = "Crear";
            this.butCrear.UseVisualStyleBackColor = true;
            this.butCrear.Click += new System.EventHandler(this.butCrear_Click);
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(298, 22);
            this.butBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(58, 34);
            this.butBorrar.TabIndex = 2;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(370, 22);
            this.butModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(58, 34);
            this.butModificar.TabIndex = 3;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Medico";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sintomas";
            // 
            // textSintomas
            // 
            this.textSintomas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSintomas.Enabled = false;
            this.textSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSintomas.Location = new System.Drawing.Point(463, 133);
            this.textSintomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSintomas.Multiline = true;
            this.textSintomas.Name = "textSintomas";
            this.textSintomas.Size = new System.Drawing.Size(323, 140);
            this.textSintomas.TabIndex = 11;
            // 
            // comboMedicName
            // 
            this.comboMedicName.Enabled = false;
            this.comboMedicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMedicName.FormattingEnabled = true;
            this.comboMedicName.Location = new System.Drawing.Point(298, 193);
            this.comboMedicName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboMedicName.Name = "comboMedicName";
            this.comboMedicName.Size = new System.Drawing.Size(138, 28);
            this.comboMedicName.TabIndex = 12;
            this.comboMedicName.SelectedIndexChanged += new System.EventHandler(this.comboMedicName_SelectedIndexChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(72, 98);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(138, 26);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(72, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(72, 195);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(138, 26);
            this.txtApellido.TabIndex = 15;
            // 
            // listCitas
            // 
            this.listCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCitas.FormattingEnabled = true;
            this.listCitas.Location = new System.Drawing.Point(10, 330);
            this.listCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCitas.Name = "listCitas";
            this.listCitas.Size = new System.Drawing.Size(774, 121);
            this.listCitas.TabIndex = 17;
            this.listCitas.SelectedIndexChanged += new System.EventHandler(this.listCitas_SelectedIndexChanged);
            this.listCitas.DoubleClick += new System.EventHandler(this.listCitas_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Citas";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 460);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Notas";
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Enabled = false;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(9, 483);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(776, 99);
            this.txtNotas.TabIndex = 20;
            // 
            // butCrearCita
            // 
            this.butCrearCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCrearCita.Location = new System.Drawing.Point(721, 299);
            this.butCrearCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCrearCita.Name = "butCrearCita";
            this.butCrearCita.Size = new System.Drawing.Size(63, 26);
            this.butCrearCita.TabIndex = 21;
            this.butCrearCita.Text = "Crear cita";
            this.butCrearCita.UseVisualStyleBackColor = true;
            this.butCrearCita.Click += new System.EventHandler(this.butCrearCita_Click);
            // 
            // butBorrarCita
            // 
            this.butBorrarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butBorrarCita.Location = new System.Drawing.Point(650, 298);
            this.butBorrarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butBorrarCita.Name = "butBorrarCita";
            this.butBorrarCita.Size = new System.Drawing.Size(66, 26);
            this.butBorrarCita.TabIndex = 22;
            this.butBorrarCita.Text = "Borrar cita";
            this.butBorrarCita.UseVisualStyleBackColor = true;
            this.butBorrarCita.Click += new System.EventHandler(this.butBorrarCita_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Enabled = false;
            this.numEdad.Location = new System.Drawing.Point(298, 148);
            this.numEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(90, 20);
            this.numEdad.TabIndex = 25;
            // 
            // numTelefono
            // 
            this.numTelefono.Enabled = false;
            this.numTelefono.InterceptArrowKeys = false;
            this.numTelefono.Location = new System.Drawing.Point(298, 102);
            this.numTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numTelefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Size = new System.Drawing.Size(119, 20);
            this.numTelefono.TabIndex = 26;
            // 
            // butAplicar
            // 
            this.butAplicar.Location = new System.Drawing.Point(448, 22);
            this.butAplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAplicar.Name = "butAplicar";
            this.butAplicar.Size = new System.Drawing.Size(58, 34);
            this.butAplicar.TabIndex = 27;
            this.butAplicar.Text = "Aplicar";
            this.butAplicar.UseVisualStyleBackColor = true;
            this.butAplicar.Visible = false;
            this.butAplicar.Click += new System.EventHandler(this.butAplicar_Click);
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 600);
            this.Controls.Add(this.butAplicar);
            this.Controls.Add(this.numTelefono);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.butBorrarCita);
            this.Controls.Add(this.butCrearCita);
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
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butCrear);
            this.Controls.Add(this.comboBuscador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button butCrear;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.Button butModificar;
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
        private System.Windows.Forms.Button butCrearCita;
        private System.Windows.Forms.Button butBorrarCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numTelefono;
        private System.Windows.Forms.Button butAplicar;
    }
}