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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            RecargarDatosDelPersonal();
        }

        void RecargarDatosDelPersonal() 
        {
            // Con datagriwview actualizar mostrando todos las personas que haya
            // en la lista de Program.PersonasEnElHospital

            var listaConTipo = Program.PersonasEnElHospital.Select(p => new
            {
                // Obtiene el nombre de la clase (Medico, Paciente, Personal administrivo)
                Tipo = p.GetType().Name,  
                DNI = p.DNI,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Edad = p.Edad,
                Telefono = p.Telefono,
                Especialidad = p is Medico ? ((Medico)p).Especialidad.ToString() : null,  // Solo médicos tienen especialidad
                Sintoma = p is Paciente ? ((Paciente)p).Sintoma : null  // Solo pacientes tienen sintomas
            }).ToList();

            // Asignamos la lista al DataGridView
            dataGridPersonas.DataSource = listaConTipo;
        }

        private void Paciente_Click(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente();
            formPaciente.ShowDialog();
            RecargarDatosDelPersonal();
        }

        private void butMedico_Click(object sender, EventArgs e)
        {
            FormMedico formMedico = new FormMedico();
            formMedico.ShowDialog();
            RecargarDatosDelPersonal();
        }

        private void butPersAdm_Click(object sender, EventArgs e)
        {
            FormPersAdmin formPersAdmin = new FormPersAdmin();
            formPersAdmin.ShowDialog();
            RecargarDatosDelPersonal();

        }

        private void dataGridViewPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            dataGridPersonas.BackgroundColor = Color.White;

            if (dataGridPersonas.Columns[e.ColumnIndex].Name != "Tipo")
                return;

            // Obtenemos el tipo de la clase para diferenciarla
            string tipo = e.Value?.ToString();

            // Referencia a la fila actual
            var row = dataGridPersonas.Rows[e.RowIndex];

            // Por defecto (en caso de valor nulo o desconocido)
            Color backColor = Color.White;
            Color foreColor = Color.Black;

            if (tipo == "Medico")
            {
                backColor = Color.LightBlue;
                foreColor = Color.Black;
            }
            else if (tipo == "Paciente")
            {
                backColor = ColorTranslator.FromHtml("#f2ee80");
                foreColor = Color.Black;
            }
            else if (tipo == "PersonalAdministrativo")
            {
                backColor = Color.Bisque;
                foreColor = Color.Black;
            }

            row.DefaultCellStyle.BackColor = backColor;
            row.DefaultCellStyle.ForeColor = foreColor;

            row.DefaultCellStyle.SelectionBackColor = backColor;
            row.DefaultCellStyle.SelectionForeColor = foreColor;

            dataGridPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void dataGridViewPersonal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridPersonas.InvalidateRow(e.RowIndex);
                dataGridPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridPersonas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }
    }
}
