namespace GestionHospital
{
    partial class FormMedico
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
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.listPacientes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            this.butAplicar = new System.Windows.Forms.Button();
            this.butAnadirPaciente = new System.Windows.Forms.Button();
            this.comboPaciente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBuscador
            // 
            this.comboBuscador.FormattingEnabled = true;
            this.comboBuscador.Location = new System.Drawing.Point(12, 37);
            this.comboBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBuscador.Name = "comboBuscador";
            this.comboBuscador.Size = new System.Drawing.Size(265, 24);
            this.comboBuscador.TabIndex = 0;
            this.comboBuscador.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // butCrear
            // 
            this.butCrear.Location = new System.Drawing.Point(301, 27);
            this.butCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCrear.Name = "butCrear";
            this.butCrear.Size = new System.Drawing.Size(77, 42);
            this.butCrear.TabIndex = 1;
            this.butCrear.Text = "Crear";
            this.butCrear.UseVisualStyleBackColor = true;
            this.butCrear.Click += new System.EventHandler(this.butCrear_Click);
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(397, 27);
            this.butBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(77, 42);
            this.butBorrar.TabIndex = 2;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(493, 27);
            this.butModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(77, 42);
            this.butModificar.TabIndex = 3;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
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
            this.label3.Location = new System.Drawing.Point(9, 121);
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
            this.label5.Location = new System.Drawing.Point(318, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Especialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pacientes(Con/Sin medico)";
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.Enabled = false;
            this.comboEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Location = new System.Drawing.Point(428, 240);
            this.comboEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(220, 33);
            this.comboEspecialidad.TabIndex = 12;
            this.comboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboEspecialidad_SelectedIndexChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(96, 121);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(183, 30);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(96, 175);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 30);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(96, 240);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 30);
            this.txtApellido.TabIndex = 15;
            // 
            // listPacientes
            // 
            this.listPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPacientes.FormattingEnabled = true;
            this.listPacientes.HorizontalScrollbar = true;
            this.listPacientes.ItemHeight = 25;
            this.listPacientes.Location = new System.Drawing.Point(13, 406);
            this.listPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPacientes.Name = "listPacientes";
            this.listPacientes.Size = new System.Drawing.Size(1031, 129);
            this.listPacientes.TabIndex = 17;
            this.listPacientes.SelectedIndexChanged += new System.EventHandler(this.listPacientes_SelectedIndexChanged);
            this.listPacientes.DoubleClick += new System.EventHandler(this.listPacientes_DoubleClick);
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
            this.txtNotas.Location = new System.Drawing.Point(12, 594);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(1033, 121);
            this.txtNotas.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Enabled = false;
            this.numEdad.Location = new System.Drawing.Point(428, 183);
            this.numEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 22);
            this.numEdad.TabIndex = 25;
            // 
            // numTelefono
            // 
            this.numTelefono.Enabled = false;
            this.numTelefono.InterceptArrowKeys = false;
            this.numTelefono.Location = new System.Drawing.Point(428, 126);
            this.numTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numTelefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Size = new System.Drawing.Size(159, 22);
            this.numTelefono.TabIndex = 26;
            // 
            // butAplicar
            // 
            this.butAplicar.Location = new System.Drawing.Point(597, 27);
            this.butAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAplicar.Name = "butAplicar";
            this.butAplicar.Size = new System.Drawing.Size(77, 42);
            this.butAplicar.TabIndex = 27;
            this.butAplicar.Text = "Aplicar";
            this.butAplicar.UseVisualStyleBackColor = true;
            this.butAplicar.Visible = false;
            this.butAplicar.Click += new System.EventHandler(this.butAplicar_Click);
            // 
            // butAnadirPaciente
            // 
            this.butAnadirPaciente.Location = new System.Drawing.Point(261, 367);
            this.butAnadirPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAnadirPaciente.Name = "butAnadirPaciente";
            this.butAnadirPaciente.Size = new System.Drawing.Size(131, 32);
            this.butAnadirPaciente.TabIndex = 21;
            this.butAnadirPaciente.Text = "Añadir paciente";
            this.butAnadirPaciente.UseVisualStyleBackColor = true;
            this.butAnadirPaciente.Click += new System.EventHandler(this.butAnadirPaciente_Click);
            // 
            // comboPaciente
            // 
            this.comboPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaciente.FormattingEnabled = true;
            this.comboPaciente.Location = new System.Drawing.Point(13, 367);
            this.comboPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPaciente.Name = "comboPaciente";
            this.comboPaciente.Size = new System.Drawing.Size(228, 33);
            this.comboPaciente.TabIndex = 28;
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 738);
            this.Controls.Add(this.comboPaciente);
            this.Controls.Add(this.butAplicar);
            this.Controls.Add(this.numTelefono);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.butAnadirPaciente);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listPacientes);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.comboEspecialidad);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMedico";
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
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ListBox listPacientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numTelefono;
        private System.Windows.Forms.Button butAplicar;
        private System.Windows.Forms.Button butAnadirPaciente;
        private System.Windows.Forms.ComboBox comboPaciente;
    }
}