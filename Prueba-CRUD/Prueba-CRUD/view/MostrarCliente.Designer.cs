namespace tutorialYT.view
{
    partial class MostrarCliente
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
            btnBuscarClientePorId = new Button();
            btnMostrarTodosLosCLientes = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridViewMostrarClientes = new DataGridView();
            btnMostrarClienteMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMostrarClientes).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarClientePorId
            // 
            btnBuscarClientePorId.Location = new Point(134, 116);
            btnBuscarClientePorId.Name = "btnBuscarClientePorId";
            btnBuscarClientePorId.Size = new Size(94, 29);
            btnBuscarClientePorId.TabIndex = 0;
            btnBuscarClientePorId.Text = "buscar";
            btnBuscarClientePorId.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodosLosCLientes
            // 
            btnMostrarTodosLosCLientes.Location = new Point(432, 263);
            btnMostrarTodosLosCLientes.Name = "btnMostrarTodosLosCLientes";
            btnMostrarTodosLosCLientes.Size = new Size(220, 29);
            btnMostrarTodosLosCLientes.TabIndex = 1;
            btnMostrarTodosLosCLientes.Text = "MostrarTodos los clientes";
            btnMostrarTodosLosCLientes.UseVisualStyleBackColor = true;
            btnMostrarTodosLosCLientes.Click += btnMostrarTodosLosCLientes_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 66);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Id cliente";
            // 
            // dataGridViewMostrarClientes
            // 
            dataGridViewMostrarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMostrarClientes.Location = new Point(288, 12);
            dataGridViewMostrarClientes.Name = "dataGridViewMostrarClientes";
            dataGridViewMostrarClientes.RowHeadersWidth = 51;
            dataGridViewMostrarClientes.RowTemplate.Height = 29;
            dataGridViewMostrarClientes.Size = new Size(500, 234);
            dataGridViewMostrarClientes.TabIndex = 4;
            dataGridViewMostrarClientes.CellContentClick += dataGridViewMostrarClientes_CellContentClick;
            // 
            // btnMostrarClienteMain
            // 
            btnMostrarClienteMain.Location = new Point(36, 263);
            btnMostrarClienteMain.Name = "btnMostrarClienteMain";
            btnMostrarClienteMain.Size = new Size(94, 29);
            btnMostrarClienteMain.TabIndex = 5;
            btnMostrarClienteMain.Text = "volver";
            btnMostrarClienteMain.UseVisualStyleBackColor = true;
            btnMostrarClienteMain.Click += btnMostrarClienteMain_Click;
            // 
            // MostrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 314);
            Controls.Add(btnMostrarClienteMain);
            Controls.Add(dataGridViewMostrarClientes);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnMostrarTodosLosCLientes);
            Controls.Add(btnBuscarClientePorId);
            Name = "MostrarCliente";
            Text = "MostrarCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMostrarClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarClientePorId;
        private Button btnMostrarTodosLosCLientes;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridViewMostrarClientes;
        private Button btnMostrarClienteMain;
    }
}