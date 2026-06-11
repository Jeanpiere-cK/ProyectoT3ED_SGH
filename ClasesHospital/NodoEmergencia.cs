using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoEmergencia
    {
        public Paciente Datos { get; set; }
        public NodoEmergencia Sig { get; set; }

        public NodoEmergencia(Paciente paciente)
        {
            Datos = paciente;
            Sig = null;
        }
    }
}
