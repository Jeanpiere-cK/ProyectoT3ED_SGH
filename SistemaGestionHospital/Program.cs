using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesHospital;

namespace SistemaGestionHospital
{
    public class Program
    {
        static void Main(string[] args)
        {

            {
                LogicaListaPacientes listaPacientes = new LogicaListaPacientes();
                ColaEmergencias colaEmergencias = new ColaEmergencias();
                ArbolMedicos arbolMedicos = new ArbolMedicos();
                ListaCitas listaCitas = new ListaCitas();

                int opcion = 0;

                while (opcion != 6)
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("    SISTEMA DE GESTIÓN HOSPITALARIA    ");
                    Console.WriteLine("========================================");
                    Console.WriteLine("1. Registrar Paciente (Código Automático)");
                    Console.WriteLine("2. Registrar Médico (Manual)");
                    Console.WriteLine("3. Ingresar Paciente a Emergencias (Cola)");
                    Console.WriteLine("4. Atender Siguiente Emergencia");
                    Console.WriteLine("5. Programar Cita Médica (Código Automático)");
                    Console.WriteLine("6. Salir del Sistema");
                    Console.WriteLine("========================================");
                    Console.Write("Seleccione una opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("--- REGISTRAR NUEVO PACIENTE ---");
                            // Ya no pedimos el código aquí
                            Console.Write("Nombre Completo: ");
                            string nomP = Console.ReadLine();
                            Console.Write("Edad: ");
                            int edadP = int.Parse(Console.ReadLine());
                            Console.Write("DNI: ");
                            string dniP = Console.ReadLine();
                            Console.Write("Teléfono: ");
                            string telP = Console.ReadLine();
                            Console.Write("Sexo: ");
                            string sexP = Console.ReadLine();

                            // Pasamos 0 temporalmente, la estructura se encargará de cambiarlo
                            Paciente nuevoPaciente = new Paciente(0, nomP, edadP, dniP, telP, sexP);
                            listaPacientes.AgregarPaciente(nuevoPaciente);

                            Console.WriteLine($"\n¡Paciente registrado! Código asignado: {nuevoPaciente.Codigo}");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("--- REGISTRAR NUEVO MÉDICO ---");
                            Console.Write("Código del Médico: ");
                            int codM = int.Parse(Console.ReadLine());
                            Console.Write("Nombre del Médico: ");
                            string nomM = Console.ReadLine();
                            Console.Write("Especialidad: ");
                            string espM = Console.ReadLine();

                            Medico nuevoMedico = new Medico(codM, nomM, espM);
                            arbolMedicos.Insertar(nuevoMedico);

                            Console.WriteLine("\n¡Médico insertado correctamente!");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("--- INGRESO A EMERGENCIAS ---");
                            Console.Write("Ingrese el DNI del paciente: ");
                            string dniBuscar = Console.ReadLine();

                            Paciente pacienteE = listaPacientes.BuscarPaciente(dniBuscar);

                            if (pacienteE != null)
                            {
                                colaEmergencias.Encolar(pacienteE);
                                Console.WriteLine($"\nEl paciente {pacienteE.Nombre} fue enviado a la Cola.");
                            }
                            else
                            {
                                Console.WriteLine("\nError: El paciente no existe.");
                            }
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("--- ATENCIÓN DE EMERGENCIAS ---");

                            Paciente pacienteAtendido = colaEmergencias.Desencolar();

                            if (pacienteAtendido != null)
                            {
                                Console.WriteLine($"Atendiendo a: {pacienteAtendido.Nombre} (Código: {pacienteAtendido.Codigo})");
                                Console.Write("Diagnóstico: ");
                                string diag = Console.ReadLine();
                                Console.Write("Tratamiento: ");
                                string trat = Console.ReadLine();

                                ConsultaMedica nuevaConsulta = new ConsultaMedica(DateTime.Now, diag, trat);

                                if (pacienteAtendido.Historial == null)
                                    pacienteAtendido.Historial = new HistorialClinico();

                                pacienteAtendido.Historial.ApilarConsulta(nuevaConsulta);

                                Console.WriteLine("\n¡Atención guardada en la Pila del paciente!");
                            }
                            else
                            {
                                Console.WriteLine("No hay pacientes en la cola.");
                            }
                            Console.ReadLine();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("--- REGISTRAR CITA MÉDICA ---");
                            // Ya no pedimos el código de la cita tampoco

                            Console.Write("DNI del Paciente: ");
                            string dniC = Console.ReadLine();
                            Paciente pacCita = listaPacientes.BuscarPaciente(dniC);

                            Console.Write("Código del Médico: ");
                            int codMedCita = int.Parse(Console.ReadLine());
                            Medico medCita = arbolMedicos.Buscar(codMedCita);

                            if (pacCita != null && medCita != null)
                            {
                                Console.Write("Fecha (DD/MM/AAAA hh:mm): ");
                                DateTime fechaCita = DateTime.Parse(Console.ReadLine());

                                Cita nuevaCita = new Cita(0, pacCita, medCita, fechaCita);
                                listaCitas.AgregarCita(nuevaCita);

                                Console.WriteLine($"\n¡Cita agendada! Código de Cita automático: {nuevaCita.Codigo}");
                            }
                            else
                            {
                                Console.WriteLine("\nError: Datos no encontrados.");
                            }
                            Console.ReadLine();
                            break;

                        case 6:
                            break;
                    }
                }
            }
        }
    }
}

