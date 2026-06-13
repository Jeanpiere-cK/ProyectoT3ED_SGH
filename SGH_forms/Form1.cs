using ClasesHospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesHospital.ListaCitas;

namespace SGH_forms
{
    public partial class Form1 : Form
    {
        private Paciente pacienteSeleccionadoParaCita = null;
        private Paciente pacienteEnTriajeActual = null;

        public Form1()
        {
            InitializeComponent();
        }
        // METODO AUXILIAR PARA REFRESCAR EL DATAGRIDVIEW
        private void ActualizarTablaPacientes()
        {
            dgvPacientes.Rows.Clear(); // Limpiamos la tabla visual

            NodoPaciente actual = EstadoSistema.ListaPacientes.ObtenerCabeza();

            while (actual != null)
            {
                
                dgvPacientes.Rows.Add(
                    actual.Datos.Codigo,
                    actual.Datos.Nombre,
                    actual.Datos.DNI,
                    actual.Datos.Edad,
                    actual.Datos.Sexo,
                    actual.Datos.Telefono
                );

                actual = actual.Sig; 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombres = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string sexo = cmbSexo.SelectedItem?.ToString() ?? "No especificado";

            // Llamamos al método Modificar de la clase lógica
            bool modificado = EstadoSistema.ListaPacientes.ModificarPaciente(dni, nombres, edad, sexo);

            if (modificado)
            {
                MessageBox.Show("Datos del paciente actualizados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTablaPacientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar. Verifique que el DNI sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, complete al menos el DNI y el Nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int codigo = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                string dni = txtDni.Text;
                string telefono = txtTelefono.Text;
                string sexo = cmbSexo.SelectedItem?.ToString() ?? "No especificado";
                
                Paciente nuevoPaciente = new Paciente(codigo, nombre, edad, dni, telefono, sexo);
                EstadoSistema.ListaPacientes.AgregarPaciente(nuevoPaciente);
                MessageBox.Show("Paciente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTablaPacientes(); // Refrescar Grid
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = txtDni.Text;

            Paciente encontrado = EstadoSistema.ListaPacientes.BuscarPaciente(dniABuscar);

            if (encontrado != null)
            {
                // Llenamos los textBox con los datos encontrados para que el usuario los vea
                txtCodigo.Text = encontrado.Codigo.ToString();
                txtNombre.Text = encontrado.Nombre;
                txtEdad.Text = encontrado.Edad.ToString();
                txtTelefono.Text = encontrado.Telefono;
                cmbSexo.SelectedItem = encontrado.Sexo;

                MessageBox.Show("Paciente encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            // Confirmacion antes de borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar al paciente con DNI {dni}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                bool eliminado = EstadoSistema.ListaPacientes.EliminarPaciente(dni);

                if (eliminado)
                {
                    MessageBox.Show("Paciente eliminado del sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTablaPacientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            cmbSexo.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtNombreMedico.Text) || string.IsNullOrWhiteSpace(txtCodigoMedico.Text))
                {
                    MessageBox.Show("Por favor, complete el Código y el Nombre del médico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturar datos
                int codigo = int.Parse(txtCodigoMedico.Text);
                string nombre = txtNombreMedico.Text;
                string especialidad = cmbEspecialidad.SelectedItem?.ToString() ?? "Medicina General";

                // Crear el objeto Médico
                Medico nuevoMedico = new Medico(codigo, nombre, especialidad);

                // Insertar en el Árbol Binario Global
                EstadoSistema.ArbolMedicos.Insertar(nuevoMedico);

                MessageBox.Show("Médico agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarArbolVisual();
                txtCodigoMedico.Clear();
                txtNombreMedico.Clear();
                cmbEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formato de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ActualizarArbolVisual() 
        {
            tvMedicos.Nodes.Clear(); // Limpiamos el árbol visual anterior

            // Obtenemos la raíz de tu estructura binaria
            NodoMedico raiz = EstadoSistema.ArbolMedicos.ObtenerRaiz();

            if (raiz != null)
            {
                // Creamos el nodo visual principal
                TreeNode nodoVisualRaiz = new TreeNode(raiz.Datos.ToString());
                tvMedicos.Nodes.Add(nodoVisualRaiz);

                // Llamamos a la funcion recursiva para colgar los hijos izquierdo y derecho
                ConstruirNodosVisuales(raiz, nodoVisualRaiz);
            }

            tvMedicos.ExpandAll(); // Despliega todas las ramas automáticamente
        }
        private void ConstruirNodosVisuales(NodoMedico nodoLogico, TreeNode nodoVisualPadre)
        {
            // Evaluar Rama Izquierda
            if (nodoLogico.Izquierdo != null)
            {
                TreeNode visualIzquierdo = new TreeNode("Izq: " + nodoLogico.Izquierdo.Datos.ToString());
                nodoVisualPadre.Nodes.Add(visualIzquierdo);

                // Llamada recursiva para seguir bajando por la izquierda
                ConstruirNodosVisuales(nodoLogico.Izquierdo, visualIzquierdo);
            }

            // Evaluar Rama Derecha
            if (nodoLogico.Derecho != null)
            {
                TreeNode visualDerecho = new TreeNode("Der: " + nodoLogico.Derecho.Datos.ToString());
                nodoVisualPadre.Nodes.Add(visualDerecho);

                // Llamada recursiva para seguir bajando por la derecha
                ConstruirNodosVisuales(nodoLogico.Derecho, visualDerecho);
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnBuscarPacienteCita_Click(object sender, EventArgs e)
        {
            string dni = txtDniCita.Text;
            pacienteSeleccionadoParaCita = EstadoSistema.ListaPacientes.BuscarPaciente(dni);

            if (pacienteSeleccionadoParaCita != null)
            {
                lblNombrePacienteCita.Text = $"Paciente: {pacienteSeleccionadoParaCita.Nombre}";
                MessageBox.Show("Paciente verificado. Puede proceder a programar la cita.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblNombrePacienteCita.Text = "Paciente: (No encontrado)";
                MessageBox.Show("El DNI ingresado no corresponde a ningún paciente registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {

            try
            {
                if (pacienteSeleccionadoParaCita == null)
                {
                    MessageBox.Show("Debe verificar un paciente válido primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbMedicoCita.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un médico especialista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Medico medicoSeleccionado = (Medico)cmbMedicoCita.SelectedItem;
                DateTime fecha = dtpFechaCita.Value;
                int codigoAutomatico = new Random().Next(1000, 9999);

                Cita nuevaCita = new Cita(codigoAutomatico, pacienteSeleccionadoParaCita, medicoSeleccionado, fecha);

                // Insertar en la estructura ListaCitas Global
                EstadoSistema.ListaCitas.AgregarCita(nuevaCita);
                MessageBox.Show($"Cita programada con éxito.\nTicket N°: {nuevaCita.Codigo}", "Ticket Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoSistema.ColaEmergencias.Encolar(pacienteSeleccionadoParaCita);
                ActualizarListaColaVisual(); // Refresca de inmediato el ListBox de la cuarta pestaña
                ActualizarTablaCitas();

                pacienteSeleccionadoParaCita = null;
                lblNombrePacienteCita.Text = "Paciente: (No seleccionado)";
                txtDniCita.Clear();
                cmbMedicoCita.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ActualizarTablaCitas()
        {
            dgvCitas.Rows.Clear();
            NodoCita actual = EstadoSistema.ListaCitas.ObtenerCabeza();

            while (actual != null)
            {
                dgvCitas.Rows.Add(
                    actual.Datos.Codigo,
                    actual.Datos.Paciente.Nombre,
                    actual.Datos.Medico.Nombre + " (" + actual.Datos.Medico.Especialidad + ")",
                    actual.Datos.Fecha.ToString("dd/MM/yyyy hh:mm tt")
                );

                actual = actual.Sig;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarMedicosEnCombo();
        }
        private void CargarMedicosEnCombo()
        {
            cmbMedicoCita.Items.Clear();
            NodoMedico raiz = EstadoSistema.ArbolMedicos.ObtenerRaiz();
            LlenarComboInorden(raiz);
        }

        private void LlenarComboInorden(NodoMedico nodo)
        {
            if (nodo == null) return;

            LlenarComboInorden(nodo.Izquierdo); // Izquierda
            cmbMedicoCita.Items.Add(nodo.Datos); // Raíz 
            LlenarComboInorden(nodo.Derecho);   // Derecha
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMedicosEnCombo();
        }

        private void btnGuardarTriaje_Click(object sender, EventArgs e)
        {
            if (pacienteEnTriajeActual == null)
            {
                MessageBox.Show("No hay ningún paciente seleccionado para triaje.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPresion.Text) || string.IsNullOrWhiteSpace(txtTemperatura.Text))
            {
                MessageBox.Show("Por favor, ingrese los signos vitales (Presión y Temperatura).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Capturamos los datos de la interfaz
            string presion = txtPresion.Text;
            string temperatura = txtTemperatura.Text;
            DateTime fechaAhora = DateTime.Now;

            //Guardamos datos de diagnostico y tratamiento
            string diagnosticoFormateado = $"Presión Arterial: {presion}";
            string tratamientoFormateado = $"Temperatura: {temperatura}°C";

            // Creamos el objeto con el formato del constructor(fecha, diagnostico, tratamiento)
            ConsultaMedica nuevaConsulta = new ConsultaMedica(fechaAhora, diagnosticoFormateado, tratamientoFormateado);

            //Apilamos en el historial del paciente
            pacienteEnTriajeActual.Historial.ApilarConsulta(nuevaConsulta);

            MessageBox.Show($"Triaje completado para {pacienteEnTriajeActual.Nombre}.\nDatos guardados en su Historial Clínico (Pila).", "Triaje Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pacienteEnTriajeActual = null;
            lblPacienteEnTriaje.Text = "Atendiendo a: (Ninguno)";
            txtPresion.Clear();
            txtTemperatura.Clear();
        }

        private void btnAtenderSiguiente_Click(object sender, EventArgs e)
        {
            // Llama a tu método que devuelve un Paciente directo
            pacienteEnTriajeActual = EstadoSistema.ColaEmergencias.Desencolar();

            if (pacienteEnTriajeActual != null)
            {
                
                lblPacienteEnTriaje.Text = $"Atendiendo a: {pacienteEnTriajeActual.Nombre}";
                MessageBox.Show($"¡Siguiente paciente en fila!\nNombre: {pacienteEnTriajeActual.Nombre}", "Llamado de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarListaColaVisual();
            }
            else
            {
                pacienteEnTriajeActual = null;
                lblPacienteEnTriaje.Text = "Atendiendo a: (Ninguno)";
                MessageBox.Show("No hay pacientes en la sala de espera de emergencias.", "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ActualizarListaColaVisual()
        {
            lstColaEspera.Items.Clear();

            
            NodoEmergencia actual = EstadoSistema.ColaEmergencias.ObtenerInicio();
            while (actual != null)
            {
                // Agregamos el nombre del paciente al ListBox
                lstColaEspera.Items.Add(actual.Datos.Nombre);
                // Avanzamos al siguiente nodo de la cola
                actual = actual.Sig;
            }
        }
        

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            // Limpiamos espacios en blanco del texto ingresado
            string dniBuscar = txtDniHistorial.Text.Trim();
            if (string.IsNullOrEmpty(dniBuscar))
            {
                MessageBox.Show("Por favor, ingrese un DNI para realizar la búsqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Buscamos al paciente en tu Lista Enlazada global de pacientes
            Paciente pacEncontrado = EstadoSistema.ListaPacientes.BuscarPaciente(dniBuscar);

            if (pacEncontrado != null)
            {
                // Si el paciente existe llamamos al método
                MostrarPilaHistorialVisual(pacEncontrado);
            }
            else
            {
                dgvHistorial.Rows.Clear();
                MessageBox.Show("Paciente no registrado en el sistema médico.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void MostrarPilaHistorialVisual(Paciente pac)
        {
            // Limpiamos filas del DataGridView
            dgvHistorial.Rows.Clear();

            NodoConsulta actual = pac.Historial.ObtenerTope();

            if (actual == null)
            {
                MessageBox.Show($"El paciente {pac.Nombre} no registra ninguna consulta en su historial.", "Historial Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Recorremos la pila hacia abajo
            while (actual != null)
            {
                // Agregamos una fila al DataGridView 
                dgvHistorial.Rows.Add(
                    actual.Datos.Fecha.ToString("dd/MM/yyyy hh:mm tt"), 
                    actual.Datos.Diagnostico,     //Presión
                    actual.Datos.Tratamiento      //Temperatura
                );

                // Movemos el puntero al siguiente nodo de la Pila (el que está abajo)
                actual = actual.Sig;
            }
        }

    }
}
