using controller;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace tutorialYT.view
{
    public partial class FormNuevoCliente : Form
    {
        ClienteController clienteController = new ClienteController();
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.nombre = txtNombre.Text;
            nuevoCliente.apellido = txtApellido.Text;

            // Suponiendo que txtNumeroDeTelefono es un TextBox que contiene solo números
            if (ulong.TryParse(txtNumeroDeTelefono.Text, out ulong telefono))
            {
                nuevoCliente.telefono = telefono;
            }
            else
            {
                // Manejar el error: el número de teléfono no es válido
                MessageBox.Show("Ingrese un número de teléfono válido.");
                return;
            }

            // Suponiendo que txtDNI es un TextBox para el DNI
            nuevoCliente.dni = txtDni.Text;

            // Suponiendo que txtFechaNacimiento es un DatePicker o un TextBox con formato de fecha
            if (DateTime.TryParse(txtFechaNacimiento.Text, out DateTime fechaNacimiento))
            {
                nuevoCliente.fechaNacimiento = fechaNacimiento;
            }
            else
            {
                // Manejar el error: la fecha de nacimiento no es válida
                MessageBox.Show("Ingrese una fecha de nacimiento válida.");
                return;
            }

            // Aquí puedes agregar código para guardar el nuevo cliente en la base de datos
        
            clienteController.agregarCliente(nuevoCliente);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverAgregarMain_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();

        }
    }
}
