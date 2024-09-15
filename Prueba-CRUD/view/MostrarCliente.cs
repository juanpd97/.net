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

namespace tutorialYT.view
{
    public partial class MostrarCliente : Form
    {
        ClienteController clienteController = new ClienteController();
        public MostrarCliente()
        {
            InitializeComponent();
        }

        private void btnMostrarClienteMain_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
        /*
        private void btnMostrarTodosLosCLientes_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void dataGridViewMostrarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarTodosLosCLientes_Click_1(object sender, EventArgs e)
        {
            dataGridViewMostrarClientes.DataSource = clienteController.mostrarTodosLosCLiente();
        }

        private void btnBuscarClientePorId_Click(object sender, EventArgs e)
        {
            if (clienteController.buscarClientePorId(Convert.ToInt32(txtBuscarPorId.Text)) != null)
            {
                dataGridViewMostrarClientes.DataSource = clienteController.buscarClientePorId(Convert.ToInt32(txtBuscarPorId.Text));
            }
            else { MessageBox.Show("cliente no encontrado"); }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MostrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarClientePorId_Click(object sender, EventArgs e)
        {
            clienteController.eliminarClientePorId(Convert.ToInt32(txtBuscarPorId.Text));
        }

        private void btnModificiarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarPorId.Text) || !int.TryParse(txtBuscarPorId.Text, out int id))
            {

            }
            else
            {
                MessageBox.Show("Error al ingresar el id");
            }
        }
    }
}
