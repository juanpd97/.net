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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            this.Hide(); // Oculta el formulario actual
            formNuevoCliente.Show();
        }

        private void btnMainMostrarCLiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            MostrarCliente mostrarCliente = new MostrarCliente();
            mostrarCliente.Show();
        }
    }
}
