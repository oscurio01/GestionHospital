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
    public partial class FormMedico : Form
    {
        bool crear = false;
        bool modificar = false;

        Paciente paciente {  get; set; }
        Medico medico { get; set; }

        public FormMedico()
        {
            InitializeComponent();

            foreach(var personas in Program.PersonasEnElHospital)
            {
                if (personas is Medico)
                    comboBuscador.Items.Add(personas);

                if(personas is Paciente && ((Paciente)personas).medico == null)
                    comboPaciente.Items.Add(personas);
                
            }

            foreach(var esp in Enum.GetValues(typeof(Especialidades)))
            {
                comboEspecialidad.Items.Add(esp);
            }
        }
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            if (comboBuscador.Items.Count != 0)
            {
                comboBuscador.DataSource = medico;

                comboBuscador.ValueMember = "DNI";
                comboBuscador.DisplayMember = "Nombre";

                comboBuscador.SelectedIndex = 0;
            }

            if(comboEspecialidad.Items.Count != 0)
            {
                comboEspecialidad.SelectedIndex = (int)((Medico)comboBuscador.Items[comboBuscador.SelectedIndex]).Especialidad;
            }

            if (comboPaciente.Items.Count != 0)
            {
                comboPaciente.DisplayMember = "Nombre";
                comboPaciente.SelectedIndex = 0;
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
                butAnadirPaciente.Enabled = false;

                comboBuscador.Enabled = false;
                comboPaciente.Enabled = false;

                medico = null;
                txtDNI.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                numTelefono.Text = string.Empty;
                numEdad.Text = string.Empty;
                comboEspecialidad.Text = string.Empty;
                txtNotas.Text = string.Empty;
                listPacientes.Items.Clear();

            }
            else // Implica cancelar la modificacion
            {
                butCrear.Text = "Crear";
                butModificar.Enabled = true;
                butAplicar.Visible = false;
                butBorrar.Enabled = true;
                butAnadirPaciente.Enabled = true;

                comboBuscador.Enabled = true;
                comboPaciente.Enabled = true;
                if(comboPaciente.Items.Count >= 0)
                    comboPaciente.SelectedIndex = 0;
                comboBuscador.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
            }

            txtDNI.Enabled = crear;
            txtNombre.Enabled = crear;
            txtApellido.Enabled = crear;
            numTelefono.Enabled = crear;
            numEdad.Enabled = crear;
            comboEspecialidad.Enabled = crear;
            txtNotas.Enabled = crear;

        }

        private void DarAltaMedico(object sender, EventArgs e)
        {

            if(Program.LeerDNIExacto<Persona>(txtDNI.Text) != null)
            {
                MessageBox.Show("Por favor elige otro dni, este ya ha sido escogido");
                return;
            }

            Persona p;

            //Consigue los datos de una persona y los aplica al Medico
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Medico medico = new Medico(p, (Especialidades)comboEspecialidad.SelectedIndex);

            medico.AñadirPacientes(listPacientes.Items.Cast<Paciente>().ToList());

            Program.PersonasEnElHospital.Add(medico);
            comboBuscador.Items.Add(medico);

            MessageBox.Show("Se ha añadido un medico nuevo");
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
                butAnadirPaciente.Enabled = false;

                comboPaciente.Enabled = false;

            }
            else // Implica cancelar la modificacion
            {
                butModificar.Text = "Modificar";
                butAplicar.Visible = false;
                butCrear.Enabled = true;
                butBorrar.Enabled = true;
                butAnadirPaciente.Enabled = true;
                comboPaciente.Enabled = true;
                comboPaciente.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
            }

            txtDNI.Enabled = modificar;
            txtNombre.Enabled = modificar;
            txtApellido.Enabled = modificar;
            numTelefono.Enabled = modificar;
            numEdad.Enabled = modificar;
            comboEspecialidad.Enabled = modificar;
            txtNotas.Enabled = modificar;

        }

        private void ModificarDatosMedico(object sender, EventArgs e)
        {
            // sacar al Medico de la lista de PersonasEnElHospital para que su dni no cuente
            // y el Leerdni se vuelva loco
            Persona p;
            p = Program.LeerDNIExacto<Persona>(txtDNI.Text);

            Program.PersonasEnElHospital.Remove(p);
            comboBuscador.Items.Remove(p);

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Medico medico = new Medico(p, (Especialidades)comboEspecialidad.SelectedIndex);

            medico.AñadirPacientes(listPacientes.Items.Cast<Paciente>().ToList());

            Program.PersonasEnElHospital.Add(medico);
            comboBuscador.Items.Add(medico);
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(medico);

            butModificar_Click(sender, e);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(comboBuscador.Items.Count <= 1)
            {
                MessageBox.Show("Solo hay un medico no puedes eliminar mas");
                return;
            }

            // Borra de la base de datos el paciente seleccionado
            if(MessageBox.Show("Estas seguro de borrar a este Medico?", "Borrar Medico", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Persona p;
            p = Program.LeerDNIExacto<Persona>(txtDNI.Text);

            var medico = Program.PersonasEnElHospital.OfType<Medico>()
    .FirstOrDefault(m => m.Pacientes.Any(x => x == p));

            if (medico != null)
                medico.QuitarPaciente(paciente);

            comboBuscador.Items.Remove(p);
            Program.PersonasEnElHospital.Remove(p);
            MessageBox.Show("Se ha elimiado exitosamente el paciente", "", MessageBoxButtons.OK);
            comboBuscador.SelectedIndex = 0;
        }

        private void butAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres guardar los datos modificados?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (txtDNI.Text == string.Empty || txtNombre.Text == string.Empty
                || txtApellido.Text == string.Empty || numEdad.Value <= 0
                || comboEspecialidad.SelectedIndex == -1 || comboEspecialidad.Text == string.Empty)
            {
                MessageBox.Show("Por favor rellena el dni, nombre, apellido, edad y la especialidad");
                return;
            }

            if (crear)
                DarAltaMedico(sender, e);

            if (modificar)
                ModificarDatosMedico(sender, e);

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            
            medico = Program.LeerDNIExacto<Medico>(((Medico)comboBuscador.Items[comboBuscador.SelectedIndex]).DNI);

            txtDNI.Text = medico.DNI;
            txtNombre.Text = medico.Nombre;
            txtApellido.Text = medico.Apellido;
            numTelefono.Value = medico.Telefono;
            numEdad.Value = medico.Edad;
            comboEspecialidad.Text = medico.Especialidad.ToString();


            // En caso de que tenga Pacientes
            listPacientes.Items.Clear();

            if (medico.Pacientes.Count != 0)
            {
                foreach (var pacientes in medico.Pacientes)
                {
                    listPacientes.Items.Add(pacientes);
                }

                //listPacientes.DisplayMember = medico.Pacientes[0].ToString();

                listPacientes.SelectedIndex = 0;

            }

        }

        private void comboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tiene que mostrar la especialidad que escojes

            comboEspecialidad.Text = comboEspecialidad.Items[comboEspecialidad.SelectedIndex].ToString();

        }

        private void butBorrarCita_Click(object sender, EventArgs e)
        {
            if(listPacientes.Items.Count == 0)
            {
                MessageBox.Show("No hay nada que eliminar");
                return;
            }

            //paciente.CancelarCita((DateTime)((Cita)listPacientes.Items[listPacientes.SelectedIndex]).Fecha);

            listPacientes.Items.Remove(listPacientes.Items[listPacientes.SelectedIndex]);
        }

        private void butAnadirPaciente_Click(object sender, EventArgs e)
        {
            if (medico == null)
            {
                MessageBox.Show("No has eleguido ningun medico");
                return;
            }

            if(comboPaciente.Items.Count == 0)
            {
                MessageBox.Show("No hay ningun paciente para elegir");
                return;
            }
            Paciente p = (Paciente)comboPaciente.Items[comboPaciente.SelectedIndex];

            // Añadimos paciente a medico y viceversa
            medico.AñadirPaciente(p);
            //p.medico = medico;

            listPacientes.Items.Clear();

            // Añade todos los pacientes de un medico en la lista
            foreach(var paci in medico.Pacientes)
            {
                listPacientes.Items.Add(paci);
            }

            // el paciente se elimina de la lista de escoger paciente
            comboPaciente.Items.Remove(comboPaciente.Items[comboPaciente.SelectedIndex]);
            comboPaciente.SelectedIndex = -1;
            comboPaciente.Text = string.Empty;
            // LLama al buscador con el identificador del medico para reiniciar la vista
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(medico);
        }


        private void listPacientes_DoubleClick(object sender, EventArgs e)
        {
            if (listPacientes.SelectedItem != null)
            {

                // Abrir un nuevo formulario y pasarle los detalles de la cita
                FormPaciente formPaciente = new FormPaciente();
                formPaciente.ShowDialog();
            }
        }

        private void listPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
