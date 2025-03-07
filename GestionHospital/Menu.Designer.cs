namespace GestionHospital
{
    partial class Menu
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
            this.Paciente = new System.Windows.Forms.Button();
            this.butMedico = new System.Windows.Forms.Button();
            this.butPersAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Paciente
            // 
            this.Paciente.Location = new System.Drawing.Point(25, 12);
            this.Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(100, 38);
            this.Paciente.TabIndex = 1;
            this.Paciente.Text = "Paciente";
            this.Paciente.UseVisualStyleBackColor = true;
            this.Paciente.Click += new System.EventHandler(this.Paciente_Click);
            // 
            // butMedico
            // 
            this.butMedico.Location = new System.Drawing.Point(169, 12);
            this.butMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butMedico.Name = "butMedico";
            this.butMedico.Size = new System.Drawing.Size(93, 38);
            this.butMedico.TabIndex = 2;
            this.butMedico.Text = "medico";
            this.butMedico.UseVisualStyleBackColor = true;
            this.butMedico.Click += new System.EventHandler(this.butMedico_Click);
            // 
            // butPersAdm
            // 
            this.butPersAdm.Location = new System.Drawing.Point(309, 12);
            this.butPersAdm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butPersAdm.Name = "butPersAdm";
            this.butPersAdm.Size = new System.Drawing.Size(180, 38);
            this.butPersAdm.TabIndex = 8;
            this.butPersAdm.Text = "Personal administrativo";
            this.butPersAdm.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPersAdm);
            this.Controls.Add(this.butMedico);
            this.Controls.Add(this.Paciente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Paciente;
        private System.Windows.Forms.Button butMedico;
        private System.Windows.Forms.Button butPersAdm;
    }
}