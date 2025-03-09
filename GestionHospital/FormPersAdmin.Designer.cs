namespace GestionHospital
{
    partial class FormPersAdmin
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
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            this.butAplicar = new System.Windows.Forms.Button();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBuscador
            // 
            this.comboBuscador.FormattingEnabled = true;
            this.comboBuscador.Location = new System.Drawing.Point(9, 30);
            this.comboBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.comboBuscador.Name = "comboBuscador";
            this.comboBuscador.Size = new System.Drawing.Size(200, 21);
            this.comboBuscador.TabIndex = 0;
            this.comboBuscador.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // butCrear
            // 
            this.butCrear.Location = new System.Drawing.Point(226, 22);
            this.butCrear.Margin = new System.Windows.Forms.Padding(2);
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
            this.butBorrar.Margin = new System.Windows.Forms.Padding(2);
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
            this.butModificar.Margin = new System.Windows.Forms.Padding(2);
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
            this.label3.Location = new System.Drawing.Point(11, 102);
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
            this.label4.Location = new System.Drawing.Point(3, 190);
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
            this.label5.Location = new System.Drawing.Point(3, 233);
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
            this.label6.Location = new System.Drawing.Point(201, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cargo Administrativo";
            // 
            // comboCargo
            // 
            this.comboCargo.Enabled = false;
            this.comboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(360, 230);
            this.comboCargo.Margin = new System.Windows.Forms.Padding(2);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(169, 28);
            this.comboCargo.TabIndex = 12;
            this.comboCargo.SelectedIndexChanged += new System.EventHandler(this.comboCargo_SelectedIndexChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(72, 98);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(138, 26);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(72, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(72, 187);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(138, 26);
            this.txtApellido.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Enabled = false;
            this.numEdad.Location = new System.Drawing.Point(322, 105);
            this.numEdad.Margin = new System.Windows.Forms.Padding(2);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(90, 20);
            this.numEdad.TabIndex = 25;
            // 
            // numTelefono
            // 
            this.numTelefono.Enabled = false;
            this.numTelefono.InterceptArrowKeys = false;
            this.numTelefono.Location = new System.Drawing.Point(72, 233);
            this.numTelefono.Margin = new System.Windows.Forms.Padding(2);
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
            this.butAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.butAplicar.Name = "butAplicar";
            this.butAplicar.Size = new System.Drawing.Size(58, 34);
            this.butAplicar.TabIndex = 27;
            this.butAplicar.Text = "Aplicar";
            this.butAplicar.UseVisualStyleBackColor = true;
            this.butAplicar.Visible = false;
            this.butAplicar.Click += new System.EventHandler(this.butAplicar_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(338, 187);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(138, 26);
            this.txtDepartamento.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Horario";
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(322, 142);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(138, 26);
            this.txtHorario.TabIndex = 31;
            // 
            // FormPersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 315);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.butAplicar);
            this.Controls.Add(this.numTelefono);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butCrear);
            this.Controls.Add(this.comboBuscador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPersAdmin";
            this.Text = "Personal administrativo";
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
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numTelefono;
        private System.Windows.Forms.Button butAplicar;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHorario;
    }
}