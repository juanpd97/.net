using CRUD_GPT.Controllers;
using CRUD_GPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_GPT.Views
{
    public partial class vistaPrincipal : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public vistaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.edad = Convert.ToInt32(txtEdad.Text);
            nuevoUsuario.nombre = txtNombre.Text;
            nuevoUsuario.apellido = txtApellido.Text;
            nuevoUsuario.id = Convert.ToInt32(txtId.Text);

            usuarioController.crearUsuario(nuevoUsuario);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            dataGridView1.DataSource = usuarioController.ObtenerUsuarioPorId(id);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuarioController.ObtenerTodosLosUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtId.Text);
            usuarioController.eliminarUsuario(id);
        }
    }
}




