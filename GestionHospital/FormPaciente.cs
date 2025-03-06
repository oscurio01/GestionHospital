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
    public partial class FormPaciente : Form
    {
        bool crear = false;
        bool modificar = false;

        Paciente paciente {  get; set; }
        Medico medico { get; set; }

        public FormPaciente()
        {
            InitializeComponent();

            foreach(var personas in Program.PersonasEnElHospital)
            {
                if(personas is Paciente)
                    comboBuscador.Items.Add(personas);
                if (personas is Medico)
                    comboMedicName.Items.Add(personas);

            }
        }
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            if (comboBuscador.Items.Count != 0)
            {
                comboBuscador.DataSource = paciente;

                comboBuscador.ValueMember = "DNI";
                comboBuscador.DisplayMember = "Nombre";

                comboBuscador.SelectedIndex = 0;
            }

            if(comboMedicName.Items.Count != 0)
            {
                comboMedicName.ValueMember = "DNI";
                comboMedicName.DisplayMember = "Nombre";
            }
        }

        private void butCrear_Click(object sender, EventArgs e)
        {
            // Al presionar el boton se guardara las opciones que hayas puesto en el form
            crear = !crear;

            if (crear)
            {
                butCrear.Text = "Cancelar";
                butModificar.Enabled = false;
                butAplicar.Visible = true;
                butBorrar.Enabled = false;
                comboBuscador.Enabled = false;

                txtDNI.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                numTelefono.Text = string.Empty;
                numEdad.Text = string.Empty;
                comboMedicName.Text = string.Empty;
                textSintomas.Text = string.Empty;
                txtNotas.Text = string.Empty;

            }
            else // Implica cancelar la modificacion
            {
                butCrear.Text = "Crear";
                butModificar.Enabled = true;
                butAplicar.Visible = false;
                butBorrar.Enabled = true;
                comboBuscador.Enabled = true;
                comboBuscador.SelectedIndex = 0;
            }

            txtDNI.Enabled = crear;
            txtNombre.Enabled = crear;
            txtApellido.Enabled = crear;
            numTelefono.Enabled = crear;
            numEdad.Enabled = crear;
            comboMedicName.Enabled = crear;
            textSintomas.Enabled = crear;
            txtNotas.Enabled = crear;

        }

        private void DarAltaPaciente(object sender, EventArgs e)
        {
            if (!Program.PersonasEnElHospital.OfType<Medico>().Any())
            {
                MessageBox.Show("Ahora mismo no hay un medico operable, por favor de de alta a un medico");
                return;
            }
            

            if(Program.LeerDNIExacto<Persona>(txtDNI.Text) != null)
            {
                MessageBox.Show("Por favor elige otro dni, este ya ha sido escogido");
                return;
            }

            Persona p;

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Paciente paciente = new Paciente(p, textSintomas.Text, medico);
            medico.AñadirPaciente(paciente);
            Program.PersonasEnElHospital.Add(paciente);
            comboBuscador.Items.Add(paciente);

            MessageBox.Show("Se ha añadido un paciente nuevo");
            butCrear_Click(sender, e);
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            modificar = !modificar;

            if (modificar)
            {
                butModificar.Text = "Cancelar";
                butAplicar.Visible = true;
                butCrear.Enabled = false;
                butBorrar.Enabled = false;

            }
            else // Implica cancelar la modificacion
            {
                butModificar.Text = "Modificar";
                butAplicar.Visible = false;
                butCrear.Enabled = true;
                butBorrar.Enabled = true;
            }

            txtDNI.Enabled = modificar;
            txtNombre.Enabled = modificar;
            txtApellido.Enabled = modificar;
            numTelefono.Enabled = modificar;
            numEdad.Enabled = modificar;
            comboMedicName.Enabled = modificar;
            textSintomas.Enabled = modificar;
            txtNotas.Enabled = modificar;

        }

        private void ModificarDatosPaciente()
        {
            // sacar al paciente de la lista de PersonasEnElHospital para que su dni no cuente
            // y el Leerdni se vuelva loco
            Persona p;
            p = Program.LeerDNIExacto<Persona>(txtDNI.Text);

            Program.PersonasEnElHospital.Remove(p);
            

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Paciente paciente = new Paciente(p, textSintomas.Text, medico);
            medico.AñadirPaciente(paciente);
            Program.PersonasEnElHospital.Add(paciente);
            comboBuscador.Items.Add(paciente);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            // Borra de la base de datos el paciente seleccionado
        }

        private void butAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres guardar los datos modificados?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (txtDNI.Text == string.Empty || txtNombre.Text == string.Empty
                || txtApellido.Text == string.Empty || numEdad.Value <= 0
                || comboMedicName.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor rellena el dni, nombre, apellido, edad y medico");
                return;
            }

            if (crear)
                DarAltaPaciente(sender, e);

            if (modificar)
                ModificarDatosPaciente();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            
            paciente = Program.LeerDNIExacto<Paciente>(((Paciente)comboBuscador.Items[comboBuscador.SelectedIndex]).DNI);

            txtDNI.Text = paciente.DNI;
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            numTelefono.Value = paciente.Telefono;
            numEdad.Value = paciente.Edad;
            if (paciente.medico != null)
                comboMedicName.Text = paciente.medico.Nombre;
            else
                comboMedicName.Text = string.Empty;
            textSintomas.Text = paciente.Sintoma;

        }

        private void comboMedicName_SelectedIndexChanged(object sender, EventArgs e)
        {
            medico = Program.LeerDNIExacto<Medico>(((Medico)comboMedicName.Items[comboMedicName.SelectedIndex]).DNI);

            comboMedicName.Text = medico.Nombre;

        }
    }
}
