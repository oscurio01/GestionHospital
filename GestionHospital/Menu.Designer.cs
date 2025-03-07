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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paciente
            // 
            this.Paciente.Location = new System.Drawing.Point(19, 10);
            this.Paciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(75, 31);
            this.Paciente.TabIndex = 1;
            this.Paciente.Text = "Paciente";
            this.Paciente.UseVisualStyleBackColor = true;
            this.Paciente.Click += new System.EventHandler(this.Paciente_Click);
            // 
            // butMedico
            // 
            this.butMedico.Location = new System.Drawing.Point(127, 10);
            this.butMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butMedico.Name = "butMedico";
            this.butMedico.Size = new System.Drawing.Size(70, 31);
            this.butMedico.TabIndex = 2;
            this.butMedico.Text = "medico";
            this.butMedico.UseVisualStyleBackColor = true;
            this.butMedico.Click += new System.EventHandler(this.butMedico_Click);
            // 
            // butPersAdm
            // 
            this.butPersAdm.Location = new System.Drawing.Point(232, 10);
            this.butPersAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butPersAdm.Name = "butPersAdm";
            this.butPersAdm.Size = new System.Drawing.Size(135, 31);
            this.butPersAdm.TabIndex = 8;
            this.butPersAdm.Text = "Personal administrativo";
            this.butPersAdm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 221);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(574, 195);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pers. Admin.";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butPersAdm);
            this.Controls.Add(this.butMedico);
            this.Controls.Add(this.Paciente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Paciente;
        private System.Windows.Forms.Button butMedico;
        private System.Windows.Forms.Button butPersAdm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}