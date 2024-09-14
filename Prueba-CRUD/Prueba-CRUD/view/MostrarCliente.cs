using controller;
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
    }
}
