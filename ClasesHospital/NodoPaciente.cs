using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoPaciente
    {
        public Paciente Datos { get; set; }

        public NodoPaciente Sig { get; set; }

        public NodoPaciente(Paciente paciente)
        {
            Datos = paciente;
            Sig = null;
        }
    }
}
