namespace tutorialYT.view
{
    partial class FormNuevoCliente
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtNumeroDeTelefono = new TextBox();
            lblApellido = new Label();
            lblFechaNacimiento = new Label();
            lblNumeroTelefono = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnVolverAgregarMain = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(91, 330);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(212, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 3;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(212, 148);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(125, 27);
            txtFechaNacimiento.TabIndex = 4;
            // 
            // txtNumeroDeTelefono
            // 
            txtNumeroDeTelefono.Location = new Point(212, 200);
            txtNumeroDeTelefono.Name = "txtNumeroDeTelefono";
            txtNumeroDeTelefono.Size = new Size(125, 27);
            txtNumeroDeTelefono.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(57, 99);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(57, 155);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(128, 20);
            lblFechaNacimiento.TabIndex = 7;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNumeroTelefono
            // 
            lblNumeroTelefono.AutoSize = true;
            lblNumeroTelefono.Location = new Point(57, 203);
            lblNumeroTelefono.Name = "lblNumeroTelefono";
            lblNumeroTelefono.Size = new Size(144, 20);
            lblNumeroTelefono.TabIndex = 8;
            lblNumeroTelefono.Text = "Numero de telefono";
            lblNumeroTelefono.Click += label1_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(57, 246);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 9;
            lblDni.Text = "Dni";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(212, 246);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 10;
            // 
            // btnVolverAgregarMain
            // 
            btnVolverAgregarMain.Location = new Point(221, 330);
            btnVolverAgregarMain.Name = "btnVolverAgregarMain";
            btnVolverAgregarMain.Size = new Size(94, 29);
            btnVolverAgregarMain.TabIndex = 11;
            btnVolverAgregarMain.Text = "Volver";
            btnVolverAgregarMain.UseVisualStyleBackColor = true;
            btnVolverAgregarMain.Click += btnVolverAgregarMain_Click;
            // 
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 399);
            Controls.Add(btnVolverAgregarMain);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblNumeroTelefono);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(txtNumeroDeTelefono);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Name = "FormNuevoCliente";
            Text = "FormNuevoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtFechaNacimiento;
        private TextBox txtNumeroDeTelefono;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblNumeroTelefono;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnVolverAgregarMain;
    }
}