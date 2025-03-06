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
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Paciente
            // 
            this.Paciente.Location = new System.Drawing.Point(25, 12);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(100, 38);
            this.Paciente.TabIndex = 1;
            this.Paciente.Text = "Paciente";
            this.Paciente.UseVisualStyleBackColor = true;
            this.Paciente.Click += new System.EventHandler(this.Paciente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "medico";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(309, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 38);
            this.button9.TabIndex = 8;
            this.button9.Text = "Personal administrativo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Paciente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Paciente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
    }
}