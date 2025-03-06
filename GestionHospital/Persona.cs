using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Persona
    {
        public string DNI { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }

        public Persona(string dNI, int edad, string nombre, string apellido, int telefono)
        {
            DNI = dNI;
            Edad = edad;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }

        public Persona(Persona p)
        {
            DNI = p.DNI;
            Edad = p.Edad;
            Nombre = p.Nombre;
            Apellido = p.Apellido;
            Telefono = p.Telefono;
        }

        public override string ToString()
        {
            return $"DNI:{DNI}, Nombre: {Nombre} {Apellido}, edad {Edad}, telefono {Telefono}";
        }

        public static Persona DarAltaPersona(string DNI, string Nombre, string Apellido, int Edad, int Telefono)
        {
            int edad, telefono;
            string dni = "", nombre, apellido;
            Persona p;

            dni = DNI;

            edad = Edad;

            nombre = Nombre;

            apellido = Apellido;

            telefono = Telefono;

            return p = new Persona(dni, edad, nombre, apellido, telefono);
        }
    }
}
