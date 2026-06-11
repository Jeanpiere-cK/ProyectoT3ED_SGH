using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ListaCitas
    {
        private NodoCita cabeza;
        private Random rnd = new Random(); // Generador de números aleatorios

        public ListaCitas()
        {
            cabeza = null;
        }

        public NodoCita ObtenerCabeza()
        {
            return cabeza;
        }

        public void AgregarCita(Cita cita)
        {
            // Genera un código aleatorio entre 50000 y 99999 de forma automática
            cita.Codigo = rnd.Next(50000, 100000);

            NodoCita nuevo = new NodoCita(cita);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoCita aux = cabeza;
                while (aux.Sig != null)
                {
                    aux = aux.Sig;
                }
                aux.Sig = nuevo;
            }
        }
        public class NodoCita
        {
            public Cita Datos { get; set; }
            public NodoCita Sig { get; set; }

            public NodoCita(Cita cita)
            {
                Datos = cita;
                Sig = null;
            }
        }
    }
}
