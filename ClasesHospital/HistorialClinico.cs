using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class HistorialClinico
    {
        private NodoConsulta tope;

        public HistorialClinico()
        {
            tope = null;
        }

        public NodoConsulta ObtenerTope()
        {
            return tope;
        }

        public void ApilarConsulta(ConsultaMedica consulta)
        {
            NodoConsulta nuevo = new NodoConsulta(consulta);
            nuevo.Sig = tope;
            tope = nuevo;
        }
    }
}
