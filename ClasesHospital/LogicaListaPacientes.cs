using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class LogicaListaPacientes
    {
        private NodoPaciente cabeza;

        public LogicaListaPacientes()
        {
            cabeza = null;
        }
        public NodoPaciente ObtenerCabeza()
        {
            return cabeza;
        }
        public void AgregarPaciente(Paciente paciente)
        {
            NodoPaciente nuevo = new NodoPaciente(paciente);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoPaciente aux = cabeza;

                while (aux.Sig != null)
                {
                    aux = aux.Sig;
                }

                aux.Sig = nuevo;
            }
        }
        public Paciente BuscarPaciente(string dni)
        {
            NodoPaciente aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.DNI == dni)
                {
                    return aux.Datos;
                }

                aux = aux.Sig;
            }

            return null;
        }
        public void MostrarPacientes()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            NodoPaciente aux = cabeza;

            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Sig;
            }
        }
        public bool ModificarPaciente(string dni,string nombres,int edad,string sexo)
        {
            Paciente paciente = BuscarPaciente(dni);

            if (paciente == null)
                return false;

            paciente.Nombre = nombres;
            paciente.Edad = edad;
            paciente.Sexo = sexo;

            return true;
        }
        public bool EliminarPaciente(string dni)
        {
            if (cabeza == null) 
            {
                return false;
            }   
            if (cabeza.Datos.DNI == dni)
            {
                cabeza = cabeza.Sig;
                return true;
            }

            NodoPaciente actual = cabeza;

            while (actual.Sig != null)
            {
                if (actual.Sig.Datos.DNI == dni)
                {
                    actual.Sig = actual.Sig.Sig;
                    return true;
                }
                actual = actual.Sig;
            }
            return false;
        }
        

    }
}
