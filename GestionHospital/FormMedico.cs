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
        bool esCrear = false;
        bool esModificar = false;

        Medico medico { get; set; }

        BindingList<Paciente> listaPacientes = new BindingList<Paciente>();

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

            RecargarDatosDelPaciente();
        }
        void RecargarDatosDelPaciente()
        {
            var listaConTipo = listaPacientes.Select(p => new
            {
                DNI = p.DNI,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Edad = p.Edad,
                Telefono = p.Telefono,
                Sintoma = p.Sintoma 
            }).ToList();

            // Asignamos la lista al DataGridView
            dataGridPaciente.DataSource = listaConTipo;
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

            if(comboEspecialidad.Items.Count != 0 && comboBuscador.Items.Count != 0)
            {
                comboEspecialidad.SelectedIndex = (int)((Medico)comboBuscador.Items[comboBuscador.SelectedIndex]).Especialidad;
            }

            if (comboPaciente.Items.Count != 0)
            {
                comboPaciente.DisplayMember = "Nombre";
                comboPaciente.SelectedIndex = 0;
            }

            // Ajustar las columnas de los pacientes

            RecargarDatosDelPaciente();
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
                butAnadirPaciente.Enabled = false;

                comboBuscador.Enabled = false;
                comboPaciente.Enabled = false;

                medico = null;
                txtDNI.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                numTelefono.Value = 0;
                numEdad.Value = 0;
                comboEspecialidad.Text = string.Empty;
                listaPacientes.Clear();

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
                if(comboPaciente.Items.Count > 0)
                    comboPaciente.SelectedIndex = 0;
                if(comboBuscador.Items.Count > 0)
                    comboBuscador.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
            }

            txtDNI.Enabled = esCrear;
            txtNombre.Enabled = esCrear;
            txtApellido.Enabled = esCrear;
            numTelefono.Enabled = esCrear;
            numEdad.Enabled = esCrear;
            comboEspecialidad.Enabled = esCrear;
            // Actualiza las columnas de pacientes
            RecargarDatosDelPaciente();
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

            Program.PersonasEnElHospital.Add(medico);
            comboBuscador.Items.Add(medico);

            MessageBox.Show("Se ha añadido un medico nuevo");
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
                if (comboPaciente.Items.Count > 0)
                    comboPaciente.SelectedIndex = 0;
                comboBuscar_SelectedIndexChanged(sender, e);
            }

            txtDNI.Enabled = esModificar;
            txtNombre.Enabled = esModificar;
            txtApellido.Enabled = esModificar;
            numTelefono.Enabled = esModificar;
            numEdad.Enabled = esModificar;
            comboEspecialidad.Enabled = esModificar;
        }

        private void ModificarDatosMedico(object sender, EventArgs e)
        {
            // sacar al Medico de la lista de PersonasEnElHospital para que su dni no cuente
            // y el Leerdni se vuelva loco
            string antiguoDni = this.medico.DNI;

            Persona p;
            p = this.medico;

            Program.PersonasEnElHospital.Remove(p);
            comboBuscador.Items.Remove(p);
            listaPacientes.Clear();

            //Consigue los datos de una persona y los aplica al paciente
            p = Persona.DarAltaPersona(txtDNI.Text, txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numTelefono.Value);

            Medico medico = new Medico(p, (Especialidades)comboEspecialidad.SelectedIndex);

            foreach (var paci in Program.PersonasEnElHospital.OfType<Paciente>().Where(x => x.medico?.DNI == antiguoDni))
            {
                paci.AñadirMedico(medico);
                listaPacientes.Add(paci);
            }

            Program.PersonasEnElHospital.Add(medico);
            comboBuscador.Items.Add(medico);
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(medico);

            // Actualiza las columnas de pacientes
            RecargarDatosDelPaciente();

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

            foreach (var paci in Program.PersonasEnElHospital.OfType<Paciente>().Where(x => x.medico == medico))
            {
                paci.QuitarMedico();
                comboPaciente.Items.Add(paci);
            }
            comboPaciente.SelectedIndex = 0;
            comboPaciente.DisplayMember = "Nombre";

            comboBuscador.Items.Remove(p);
            Program.PersonasEnElHospital.Remove(p);
            MessageBox.Show("Se ha elimiado exitosamente el paciente", "", MessageBoxButtons.OK);
            comboBuscador.SelectedIndex = 0;
            comboBuscar_SelectedIndexChanged(sender, e);

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
            // Para crear medicos
            if (esCrear)
                DarAltaMedico(sender, e);
            // Para modificar medicos
            if (esModificar)
                ModificarDatosMedico(sender, e);

        }

        // Cuando cambia el nombre que aparece en el buscador
        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Accede a la base de datos de los pacientes y al presionar uno muestra
            // toda la informacion
            if (comboBuscador.Items.Count == 0)
                return;

            medico = Program.LeerDNIExacto<Medico>(((Medico)comboBuscador.Items[comboBuscador.SelectedIndex]).DNI);

            txtDNI.Text = medico.DNI;
            txtNombre.Text = medico.Nombre;
            txtApellido.Text = medico.Apellido;
            numTelefono.Value = medico.Telefono;
            numEdad.Value = medico.Edad;
            comboEspecialidad.Text = medico.Especialidad.ToString();


            // En caso de que tenga Pacientes
            listaPacientes.Clear();

            var paciente = Program.PersonasEnElHospital.OfType<Paciente>().FirstOrDefault(m => m.medico == medico);

            if (paciente != null)
            {
                foreach (var pacientes in Program.PersonasEnElHospital.OfType<Paciente>().Where(p => p.medico == medico))
                {
                    listaPacientes.Add(pacientes);
                }

                // Actualiza las columnas de pacientes
            }
            RecargarDatosDelPaciente();
        }

        // Cuando cambia la especialidad que habia como principal
        private void comboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tiene que mostrar la especialidad que escojes

            comboEspecialidad.Text = comboEspecialidad.Items[comboEspecialidad.SelectedIndex].ToString();

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
            p.medico = medico;

            listaPacientes.Clear();

            // Añade todos los pacientes de un medico en la lista
            foreach(var paci in Program.PersonasEnElHospital.OfType<Paciente>().Where(x => x.medico == medico))
            {
                listaPacientes.Add(paci);
            }
            // Actualiza las columnas de pacientes
            RecargarDatosDelPaciente();

            // el paciente se elimina de la lista de escoger paciente
            comboPaciente.Items.Remove(comboPaciente.Items[comboPaciente.SelectedIndex]);
            if(comboPaciente.Items.Count > 0)
                comboPaciente.SelectedIndex = 0;
            else
                comboPaciente.Text = string.Empty;
            // LLama al buscador con el identificador del medico para reiniciar la vista
            comboBuscador.SelectedIndex = comboBuscador.Items.IndexOf(medico);
        }
        private void dataGridPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaPacientes.Count <= 0)
                return;
            FormPaciente formPaciente = new FormPaciente();
            formPaciente.ShowDialog();
        }

        private void dataGridPaciente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridPaciente.InvalidateRow(e.RowIndex);
                dataGridPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void dataGridPaciente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridPaciente.BackgroundColor = Color.White;
        }
    }
}
