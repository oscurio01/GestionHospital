using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            new Paciente("12", 12, "fermin", "galgo", 633443344, "Dolor cabeza"),
            new Paciente("º1", 89, "Franco", "Olvidado", 687442233, "Disparo en la cabeza"),
            new Medico("º123", 35, "Fran", "Gafotas", 0134, Especialidades.Hematologo)
        };


        [STAThread]
        static void Main()
        {
            ((Paciente)PersonasEnElHospital[2]).medico = (Medico)PersonasEnElHospital[0];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public static P LeerDNIExacto<P>(string dni, string excepcionDNI = "") where P : Persona
        {
            if (dni == excepcionDNI)
            {
                MessageBox.Show("Esa persona no se puede elegir, usa otro dni");
                return null;
            }

            var persona = PersonasEnElHospital.OfType<P>()
                .FirstOrDefault(m => string.Compare(m.DNI, dni, StringComparison.OrdinalIgnoreCase) == 0);

            if (persona != null)
                return persona;
            

            return null;
        }
    }
}
