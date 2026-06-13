using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ArbolMedicos
    {
        private NodoMedico raiz;

        public ArbolMedicos()
        {
            raiz = null;
        }

        public NodoMedico ObtenerRaiz()
        {
            return raiz;
        }

        public void Insertar(Medico medico)
        {
            raiz = InsertarRecursivo(raiz, medico);
        }

        private NodoMedico InsertarRecursivo(NodoMedico nodo, Medico medico)
        {
            if (nodo == null)
                return new NodoMedico(medico);

            if (medico.Codigo < nodo.Datos.Codigo)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, medico);
            else if (medico.Codigo > nodo.Datos.Codigo)
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, medico);

            return nodo;
        }

        public Medico Buscar(int codigo)
        {
            return BuscarRecursivo(raiz, codigo);
        }

        private Medico BuscarRecursivo(NodoMedico nodo, int codigo)
        {
            if (nodo == null) return null;
            if (nodo.Datos.Codigo == codigo) return nodo.Datos;

            if (codigo < nodo.Datos.Codigo)
                return BuscarRecursivo(nodo.Izquierdo, codigo);
            else
                return BuscarRecursivo(nodo.Derecho, codigo);
        }
    }
}
