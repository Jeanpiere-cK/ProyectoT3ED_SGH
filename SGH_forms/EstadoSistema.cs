using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesHospital;

namespace SGH_forms
{
    public class EstadoSistema
    {
        // Declaramosnuestras estructuras de datos globales
        public static LogicaListaPacientes ListaPacientes = new LogicaListaPacientes();
        public static ArbolMedicos ArbolMedicos = new ArbolMedicos();
        public static ListaCitas ListaCitas = new ListaCitas();
        public static ColaEmergencias ColaEmergencias = new ColaEmergencias();
    }
}
