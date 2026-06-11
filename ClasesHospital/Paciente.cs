using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class Paciente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }

        // Lo dejamos como una variable pública normal de la clase
        public HistorialClinico Historial;

        public Paciente()
        {
            Historial = new HistorialClinico();
        }

        public Paciente(int codigo, string nombre, int edad, string dni, string telefono, string sexo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Edad = edad;
            DNI = dni;
            Telefono = telefono;
            Sexo = sexo;
            Historial = new HistorialClinico(); // Se inicializa la pila aquí automáticamente
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} - {DNI} - {Sexo}";
        }
    }
}
