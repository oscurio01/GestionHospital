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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Paciente = new System.Windows.Forms.Button();
            this.butMedico = new System.Windows.Forms.Button();
            this.butPersAdm = new System.Windows.Forms.Button();
            this.dataGridPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // Paciente
            // 
            this.Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paciente.Location = new System.Drawing.Point(22, 65);
            this.Paciente.Margin = new System.Windows.Forms.Padding(2);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(131, 70);
            this.Paciente.TabIndex = 1;
            this.Paciente.Text = "Paciente";
            this.Paciente.UseVisualStyleBackColor = true;
            this.Paciente.Click += new System.EventHandler(this.Paciente_Click);
            // 
            // butMedico
            // 
            this.butMedico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMedico.Location = new System.Drawing.Point(346, 65);
            this.butMedico.Margin = new System.Windows.Forms.Padding(2);
            this.butMedico.Name = "butMedico";
            this.butMedico.Size = new System.Drawing.Size(127, 70);
            this.butMedico.TabIndex = 2;
            this.butMedico.Text = "medico";
            this.butMedico.UseVisualStyleBackColor = true;
            this.butMedico.Click += new System.EventHandler(this.butMedico_Click);
            // 
            // butPersAdm
            // 
            this.butPersAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPersAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPersAdm.Location = new System.Drawing.Point(666, 65);
            this.butPersAdm.Margin = new System.Windows.Forms.Padding(2);
            this.butPersAdm.Name = "butPersAdm";
            this.butPersAdm.Size = new System.Drawing.Size(193, 70);
            this.butPersAdm.TabIndex = 8;
            this.butPersAdm.Text = "Personal administrativo";
            this.butPersAdm.UseVisualStyleBackColor = true;
            this.butPersAdm.Click += new System.EventHandler(this.butPersAdm_Click);
            // 
            // dataGridPersonas
            // 
            this.dataGridPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPersonas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPersonas.Location = new System.Drawing.Point(22, 300);
            this.dataGridPersonas.Name = "dataGridPersonas";
            this.dataGridPersonas.Size = new System.Drawing.Size(851, 193);
            this.dataGridPersonas.TabIndex = 11;
            this.dataGridPersonas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonal_CellEnter);
            this.dataGridPersonas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPersonal_CellFormatting);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.dataGridPersonas);
            this.Controls.Add(this.butPersAdm);
            this.Controls.Add(this.butMedico);
            this.Controls.Add(this.Paciente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Paciente;
        private System.Windows.Forms.Button butMedico;
        private System.Windows.Forms.Button butPersAdm;
        private System.Windows.Forms.DataGridView dataGridPersonas;
    }
}