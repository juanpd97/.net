namespace CRUD_GPT.Views
{
    partial class vistaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            labelNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            labelApellido = new Label();
            txtEdad = new TextBox();
            labelEdad = new Label();
            txtId = new TextBox();
            labelId = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            btnMostrarTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(65, 282);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(608, 306);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(27, 56);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(61, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(114, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 5;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(27, 113);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(64, 20);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "apellido";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(114, 175);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 7;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(27, 175);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 6;
            labelEdad.Text = "edad";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 230);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(48, 237);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 8;
            labelId.Text = "id";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(65, 317);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(193, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(240, 233);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(116, 28);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "mostrar por id";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.Location = new Point(668, 355);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(219, 29);
            btnMostrarTodo.TabIndex = 13;
            btnMostrarTodo.Text = "mostrar todo";
            btnMostrarTodo.UseVisualStyleBackColor = true;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            // 
            // vistaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 396);
            Controls.Add(btnMostrarTodo);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtId);
            Controls.Add(labelId);
            Controls.Add(txtEdad);
            Controls.Add(labelEdad);
            Controls.Add(txtApellido);
            Controls.Add(labelApellido);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Name = "vistaPrincipal";
            Text = "vistaPrincipal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Label labelNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtEdad;
        private Label labelEdad;
        private TextBox txtId;
        private Label labelId;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Button btnMostrarTodo;
    }
}