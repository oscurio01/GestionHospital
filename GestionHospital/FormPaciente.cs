using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDePersonalHostpital;

namespace GestionHospital
{
    public partial class FormPaciente : Form
    {
        bool modificar = false;

        Paciente paciente {  get; set; }

        public FormPaciente()
        {
            InitializeComponent();

            foreach(var paciente in Program.PersonasEnElHospital)
            {
                if(paciente is Paciente)
                    comboBuscador.Items.Add(paciente.DNI);
            }
        }
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            if (comboBuscador.SelectedIndex != -1)
                comboBuscador.SelectedIndex = 0;
            if(comboMedicName.SelectedIndex != -1)
                comboMedicName.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                MessageBox.Show("Quieres guardar los datos modificados?", "", MessageBoxButtons.YesNo);
            }
            txtDNI.Enabled = !modificar;
            txtNombre.Enabled = !modificar;
            txtApellido.Enabled = !modificar;
            numTelefono.Enabled = !modificar;
            numEdad.Enabled = !modificar;
            comboMedicName.Enabled = !modificar;
            textSintomas.Enabled = !modificar;
            txtNotas.Enabled = !modificar;

            modificar = !modificar;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            paciente = Program.LeerDNIExacto<Paciente>(comboBuscador.Text);

            txtDNI.Text = paciente.DNI;
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            numTelefono.Value = paciente.Telefono;
            numEdad.Value = paciente.Edad;
            comboMedicName.Text = paciente.medico.Nombre;
            textSintomas.Text = paciente.Sintoma;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Borra de la base de datos el paciente seleccionado
        }

    }
}
