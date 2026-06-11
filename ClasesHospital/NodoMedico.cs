using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoMedico
    {
        public Medico Datos { get; set; }
        public NodoMedico Izquierdo { get; set; }
        public NodoMedico Derecho { get; set; }

        public NodoMedico(Medico medico)
        {
            Datos = medico;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
