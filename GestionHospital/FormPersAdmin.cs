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
    public partial class FormPersAdmin : Form
    {
        bool esCrear = false;
        bool esModificar = false;

        PersonalAdministrativo persAdmin { get; set; }

        public FormPersAdmin()
        {
            InitializeComponent();

            foreach(var personas in Program.PersonasEnElHospital)
            {
                if (personas is PersonalAdministrativo)
                    comboBuscador.Items.Add(personas);        
            }

            foreach(var car in Enum.GetValues(typeof(CargoAdministrativo)))
            {
                comboCargo.Items.Add(car);
            }
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            if (comboBuscador.Items.Count != 0)
            {
                comboBuscador.DataSource = persAdmin;

                comboBuscador.ValueMember = "DNI";
                comboBuscador.DisplayMember = "Nombre";

                comboBuscador.SelectedIndex = 0;
            }

            if(comboCargo.Items.Count != 0 && comboBuscador.Items.Count > 0)
            {
                comboCargo.SelectedIndex = (int)((PersonalAdministrativo)comboBuscador.Items[comboBuscador.SelectedIndex]).CargoAdministrativo;
            }

        }

        private void butCrear_Click(object sender, EventArgs e)
        {
            // Al presionar el boton se guardara las opciones que hayas puesto en el form
            esCrear = !esCrear;

            if (esCrear)
            {
                butCrear.Text = "Cancelar";
                butModificar.Enabled = false;
                butAplicar.Visible = true;
                butBorrar.Enabled = false;
                persAdmin = null;

                comboBuscador.Enabled = false;
                txtDNI.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                numTelefono.Value = 0;
                numEdad.Value = 0;
                comboCargo.Text = string.Empty;
                txtDepartamento.Text = string.Empty;
                txtHorario.Text = string.Empty;

            }
            else // Implica cancelar la modificacion
            {
                butCrear.Text = "Crear";
                butModificar.Enabled = true;
                butAplicar.Visible = false;
                butBorrar.Enabled = true;

                comboBuscador.Enabled = true;
                if(comboBuscador.Items.Count > 0)
                    comboBuscador.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
            }

            txtDNI.Enabled = esCrear;
            txtNombre.Enabled = esCrear;
            txtApellido.Enabled = esCrear;
            numTelefono.Enabled = esCrear;
            numEdad.Enabled = esCrear;
            comboCargo.Enabled = esCrear;
            txtDepartamento.Enabled = esCrear;
            txtHorario.Enabled = esCrear;
            // Actualiza las columnas de pacientes
        }

        private void DarAltaPersAdmin(object sender, EventArgs e)
        {

            if(Program.LeerDNIExacto<Persona>(txtDNI.Text) != null)
            {
                MessageBox.Show("Por favor elige otro dni, este ya ha sido escogido");
                return;
            }

            Persona p;

            //Consigue los datos de una persona y los aplica al Medico
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            PersonalAdministrativo persAdmin = new PersonalAdministrativo(p, (CargoAdministrativo)comboCargo.SelectedIndex, txtDepartamento.Text, txtHorario.Text);

            Program.PersonasEnElHospital.Add(persAdmin);
            comboBuscador.Items.Add(persAdmin);
            comboBuscador.DisplayMember = "Nombre";

            MessageBox.Show("Se ha añadido un Personal administrativo nuevo");
            butCrear_Click(sender, e);
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            esModificar = !esModificar;

            if (esModificar)
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

            txtDNI.Enabled = esModificar;
            txtNombre.Enabled = esModificar;
            txtApellido.Enabled = esModificar;
            numTelefono.Enabled = esModificar;
            numEdad.Enabled = esModificar;
            comboCargo.Enabled = esModificar;
            txtDepartamento.Enabled = esCrear;
            txtHorario.Enabled = esCrear;
        }

        private void ModificarDatosPersAdmin(object sender, EventArgs e)
        {
            // sacar al Personal de la lista de PersonasEnElHospital para que su dni no cuente
            // y el Leerdni se vuelva loco
            Persona p;
            p = this.persAdmin;

            Program.PersonasEnElHospital.Remove(p);
            comboBuscador.Items.Remove(p);

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            PersonalAdministrativo persAdmin = new PersonalAdministrativo(p, (CargoAdministrativo)comboCargo.SelectedIndex, txtDepartamento.Text, txtHorario.Text);

            Program.PersonasEnElHospital.Add(persAdmin);
            comboBuscador.Items.Add(persAdmin);
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(persAdmin);


            butModificar_Click(sender, e);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(comboBuscador.Items.Count <= 1)
            {
                MessageBox.Show("Solo hay un Personal administrativo no puedes eliminar mas");
                return;
            }

            // Borra de la base de datos el paciente seleccionado
            if(MessageBox.Show("Estas seguro de borrar a este Personal administrativo?", "Borrar Personal administrativo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Persona p;
            p = Program.LeerDNIExacto<Persona>(txtDNI.Text);


            comboBuscador.Items.Remove(p);
            Program.PersonasEnElHospital.Remove(p);
            MessageBox.Show("Se ha elimiado exitosamente el Personal administrativo", "", MessageBoxButtons.OK);
            comboBuscador.SelectedIndex = 0;
            comboBuscar_SelectedIndexChanged(sender, e);

        }

        private void butAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres guardar los datos modificados?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (txtDNI.Text == string.Empty || txtNombre.Text == string.Empty
                || txtApellido.Text == string.Empty || numEdad.Value <= 0
                || txtDepartamento.Text == string.Empty || txtHorario.Text == string.Empty
                || comboCargo.SelectedIndex == -1 || comboCargo.Text == string.Empty)
            {
                MessageBox.Show("Por favor rellena el dni, nombre, apellido, edad, el cargo administrativo, el departamento y el horario");
                return;
            }
            // Para crear medicos
            if (esCrear)
                DarAltaPersAdmin(sender, e);
            // Para modificar medicos
            if (esModificar)
                ModificarDatosPersAdmin(sender, e);

        }

        // Cuando cambia el nombre que aparece en el buscador
        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            if (comboBuscador.Items.Count == 0)
                return;

            persAdmin = Program.LeerDNIExacto<PersonalAdministrativo>(((PersonalAdministrativo)comboBuscador.Items[comboBuscador.SelectedIndex]).DNI);

            txtDNI.Text = persAdmin.DNI;
            txtNombre.Text = persAdmin.Nombre;
            txtApellido.Text = persAdmin.Apellido;
            numTelefono.Value = persAdmin.Telefono;
            numEdad.Value = persAdmin.Edad;
            comboCargo.Text = persAdmin.CargoAdministrativo.ToString();
            txtDepartamento.Text = persAdmin.Departamento;
            txtHorario.Text = persAdmin.HorarioDeTrabajo;
        }

        // Cuando cambia la especialidad que habia como principal
        private void comboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tiene que mostrar la especialidad que escojes

            comboCargo.Text = comboCargo.Items[comboCargo.SelectedIndex].ToString();

        }

    }
}
