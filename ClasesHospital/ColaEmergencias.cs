using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ColaEmergencias
    {
        private NodoEmergencia inicio;
        private NodoEmergencia fin;

        public ColaEmergencias()
        {
            inicio = null;
            fin = null;
        }

        public NodoEmergencia ObtenerInicio()
        {
            return inicio;
        }

        public void Encolar(Paciente paciente)
        {
            NodoEmergencia nuevo = new NodoEmergencia(paciente);
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.Sig = nuevo;
                fin = nuevo;
            }
        }

        public Paciente Desencolar()
        {
            if (inicio == null) return null;

            Paciente paciente = inicio.Datos;
            inicio = inicio.Sig;

            if (inicio == null) fin = null;

            return paciente;
        }
    }
}
