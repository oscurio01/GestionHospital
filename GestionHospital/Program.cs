using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDePersonalHostpital;

namespace GestionHospital
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static List<Persona> PersonasEnElHospital = new List<Persona>()
        {
            new Medico("5552233B", 35, "Paco", "Gafotas", 699999999, Especialidades.MedicoGeneral),
            new Paciente("12", 12, "fermin", "galgo", 633443344, "Dolor cabeza")
        };


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public static P LeerDNIExacto<P>(string dni, string excepcionDNI = "") where P : Persona
        {
            if (dni == excepcionDNI)
            {
                MessageBox.Show("Esa persona no se puede elegir, usa otro dni");

            }

            var persona = PersonasEnElHospital.OfType<P>()
                .FirstOrDefault(m => string.Compare(m.DNI, dni, StringComparison.OrdinalIgnoreCase) == 0);

            if (persona != null)
                return persona;
            else
                MessageBox.Show("No se encontraron personas con el mismo DNI.");

            return null;
        }
    }
}
