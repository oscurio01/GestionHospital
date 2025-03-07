using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHospital
{
    public partial class FormCitas : Form
    {
        internal Paciente Paciente;
        bool verCita = false;
        Cita cita;
        internal FormCitas(Paciente paciente, Cita cita = null, bool verCita = false)
        {
            Paciente = paciente;
            this.cita = cita;
            this.verCita = verCita;

            InitializeComponent();
        }


        private void FormCitas_Load(object sender, EventArgs e)
        {
            txtCitaPaciente.Text = Paciente.Nombre;
            txtCitaMedico.Text = Paciente.medico.Nombre;

            if (verCita)
            {
                txtTratamiento.Text = cita.Tratamiento;
                txtDiagnostico.Text = cita.Diagnostico;
                txtNotas.Text = cita.Notas;

                txtDiagnostico.Enabled = false;
                txtTratamiento.Enabled = false;
                txtNotas.Enabled = false;
                dateTimePicker1.Enabled = false;
                butAplicar.Visible = false;
            }

        }

        private void butAplicar_Click(object sender, EventArgs e)
        {
            if (txtDiagnostico.Text == null || txtTratamiento.Text == null)
            {
                MessageBox.Show("Por favor rellena los campos");
                return;
            }

            Cita cita = new Cita(Paciente, Paciente.medico, dateTimePicker1.Value);

            cita.RegistrarDiagnosticoYTratamiento(txtDiagnostico.Text, txtTratamiento.Text);

            if(txtNotas.Text != string.Empty)
                cita.Notas = txtNotas.Text;

            Paciente.RegistrarHistorial(cita);

            Close();
        }
    }
}
