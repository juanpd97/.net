namespace tutorialYT.view
{
    partial class FormMain
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
            btnAgregarCliente = new Button();
            btnMainMostrarCLiente = new Button();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(33, 56);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(181, 29);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += button1_Click;
            // 
            // btnMainMostrarCLiente
            // 
            btnMainMostrarCLiente.Location = new Point(33, 101);
            btnMainMostrarCLiente.Name = "btnMainMostrarCLiente";
            btnMainMostrarCLiente.Size = new Size(181, 29);
            btnMainMostrarCLiente.TabIndex = 1;
            btnMainMostrarCLiente.Text = "mostrar clientes";
            btnMainMostrarCLiente.UseVisualStyleBackColor = true;
            btnMainMostrarCLiente.Click += btnMainMostrarCLiente_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 285);
            Controls.Add(btnMainMostrarCLiente);
            Controls.Add(btnAgregarCliente);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCliente;
        private Button btnMainMostrarCLiente;
    }
}