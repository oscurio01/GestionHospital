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
                butCrearCita.Enabled = false;
                butBorrarCita.Enabled = false;

                txtDNI.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                numTelefono.Value = 0;
                numEdad.Value = 0;
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
                butCrearCita.Enabled = true;
                butBorrarCita.Enabled = true;
                comboBuscador.Enabled = true;
                if(comboBuscador.Items.Count > 0)
                    comboBuscador.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
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
            paciente.AñadirMedico(medico);
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
                comboBuscar_SelectedIndexChanged(sender, e);
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

        private void ModificarDatosPaciente(object sender, EventArgs e)
        {
            // sacar al paciente de la lista de PersonasEnElHospital para que su dni no cuente
            // y el Leerdni se vuelva loco
            Paciente antiguoPaciente = this.paciente;
            Persona p;
            p = this.paciente;

            Program.PersonasEnElHospital.Remove(p);
            comboBuscador.Items.Remove(p);
            antiguoPaciente.QuitarMedico();

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Paciente paciente = new Paciente(p, textSintomas.Text, medico);

            Program.PersonasEnElHospital.Add(paciente);
            comboBuscador.Items.Add(paciente);
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(paciente);

            butModificar_Click(sender, e);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(comboBuscador.Items.Count <= 1)
            {
                MessageBox.Show("Solo hay un paciente no puedes eliminar mas");
                return;
            }

            // Borra de la base de datos el paciente seleccionado
            if(MessageBox.Show("Estas seguro de borrar a este parciente?", "Borrar paciente", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Paciente p;
            p = Program.LeerDNIExacto<Paciente>(txtDNI.Text);

            p.QuitarMedico();

            comboBuscador.Items.Remove(p);
            Program.PersonasEnElHospital.Remove(p);
            MessageBox.Show("Se ha elimiado exitosamente el paciente", "", MessageBoxButtons.OK);
            comboBuscador.SelectedIndex = 0;
        }

        private void butAplicar_Click(object sender, EventArgs e)
        {
            // Al presionar al boton aplicar te pregunta si estas seguro
            // de que quieres aplicar los cambios
            if (MessageBox.Show("Quieres guardar los datos modificados?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (txtDNI.Text == string.Empty || txtNombre.Text == string.Empty
                || txtApellido.Text == string.Empty || numEdad.Value <= 0
                || comboMedicName.SelectedIndex == -1 || comboMedicName.Text == string.Empty)
            {
                MessageBox.Show("Por favor rellena el dni, nombre, apellido, edad y medico");
                return;
            }
            // Crea el paciente
            if (crear)
                DarAltaPaciente(sender, e);
            // Modifica el paciente actual
            if (modificar)
                ModificarDatosPaciente(sender, e);

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            if (comboBuscador.Items.Count == 0)
                return;

            paciente = Program.LeerDNIExacto<Paciente>(((Paciente)comboBuscador.Items[comboBuscador.SelectedIndex]).DNI);

            txtDNI.Text = paciente.DNI;
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            numTelefono.Value = paciente.Telefono;
            numEdad.Value = paciente.Edad;
            // comprueba si tiene medico y le indica al drop de medico su ubicacion
            if (paciente.medico != null)
            {
                comboMedicName.Text = paciente.medico.Nombre;
                comboMedicName.SelectedIndex = comboMedicName.Items.IndexOf(paciente.medico);
            }
            else
                comboMedicName.Text = string.Empty;
            textSintomas.Text = paciente.Sintoma;

            // En caso de que tenga un historial medico
            listCitas.Items.Clear();

            if (paciente.HistorialMedico.Count != 0)
            {
                foreach (var citas in paciente.HistorialMedico)
                {
                    listCitas.Items.Add(citas);
                    listCitas.DisplayMember = citas.ToString();
                }
                listCitas.SelectedIndex = 0;
            }
            else
                txtNotas.Text = string.Empty;

        }

        private void comboMedicName_SelectedIndexChanged(object sender, EventArgs e)
        {
            medico = Program.LeerDNIExacto<Medico>(((Medico)comboMedicName.Items[comboMedicName.SelectedIndex]).DNI);

            comboMedicName.Text = medico.Nombre;

        }

        private void butBorrarCita_Click(object sender, EventArgs e)
        {
            if(listCitas.Items.Count == 0)
            {
                MessageBox.Show("No hay nada que eliminar");
                return;
            }

            paciente.CancelarCita((DateTime)((Cita)listCitas.Items[listCitas.SelectedIndex]).Fecha);

            listCitas.Items.Remove(listCitas.Items[listCitas.SelectedIndex]);
        }

        private void butCrearCita_Click(object sender, EventArgs e)
        {
            if(paciente == null)
            {
                MessageBox.Show("No has elegido ningun paciente");
                return;
            }

            if (paciente.medico == null)
            {
                MessageBox.Show("Ahora mismo no hay un medico operable, por favor de de alta a un medico y asigneselo");
                return;
            }


            FormCitas formCitas = new FormCitas(paciente);

            formCitas.ShowDialog();

            listCitas.Items.Clear();

            foreach(var citas in paciente.HistorialMedico)
            {
                listCitas.Items.Add(citas);
            }
            
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(paciente);
        }


        private void listCitas_DoubleClick(object sender, EventArgs e)
        {
            if (listCitas.SelectedItem != null)
            {

                // Abrir un nuevo formulario y pasarle los detalles de la cita
                FormCitas formCita = new FormCitas(paciente, (Cita)listCitas.Items[listCitas.SelectedIndex], true);
                formCita.ShowDialog();
            }
        }

        private void listCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCitas.Items.Count <= 0 || listCitas.SelectedIndex == -1)
                return;
            txtNotas.Text = ((Cita)listCitas.Items[listCitas.SelectedIndex]).Notas;
        }
    }
}
