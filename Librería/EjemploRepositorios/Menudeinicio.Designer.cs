namespace CPresentacion
{
    partial class Menudeinicio
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
            btEmpleados = new Boton();
            btAutor = new Boton();
            btClientes = new Boton();
            panelRedondeado1 = new PanelRedondeado();
            lblBienvenido = new CustomLabel();
            btSalirSistema = new Boton();
            panelRedondeado1.SuspendLayout();
            SuspendLayout();
            // 
            // btEmpleados
            // 
            btEmpleados.BackColor = Color.Black;
            btEmpleados.BackgroundColor = Color.Black;
            btEmpleados.BorderColor = Color.DeepPink;
            btEmpleados.BorderRadius = 40;
            btEmpleados.BorderSize = 3;
            btEmpleados.FlatAppearance.BorderSize = 0;
            btEmpleados.FlatStyle = FlatStyle.Flat;
            btEmpleados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEmpleados.ForeColor = Color.White;
            btEmpleados.Location = new Point(22, 107);
            btEmpleados.Margin = new Padding(3, 4, 3, 4);
            btEmpleados.Name = "btEmpleados";
            btEmpleados.Size = new Size(300, 41);
            btEmpleados.TabIndex = 3;
            btEmpleados.Text = "Gestionar Empleados";
            btEmpleados.TextColor = Color.White;
            btEmpleados.UseVisualStyleBackColor = false;
            // 
            // btAutor
            // 
            btAutor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAutor.BackColor = Color.Black;
            btAutor.BackgroundColor = Color.Black;
            btAutor.BorderColor = Color.DeepPink;
            btAutor.BorderRadius = 40;
            btAutor.BorderSize = 3;
            btAutor.FlatAppearance.BorderSize = 0;
            btAutor.FlatStyle = FlatStyle.Flat;
            btAutor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAutor.ForeColor = Color.White;
            btAutor.Location = new Point(22, 44);
            btAutor.Margin = new Padding(3, 4, 3, 4);
            btAutor.Name = "btAutor";
            btAutor.Size = new Size(300, 41);
            btAutor.TabIndex = 2;
            btAutor.Text = "Gestionar Autores";
            btAutor.TextColor = Color.White;
            btAutor.UseVisualStyleBackColor = false;
            // 
            // btClientes
            // 
            btClientes.BackColor = Color.Black;
            btClientes.BackgroundColor = Color.Black;
            btClientes.BorderColor = Color.DeepPink;
            btClientes.BorderRadius = 40;
            btClientes.BorderSize = 3;
            btClientes.FlatAppearance.BorderSize = 0;
            btClientes.FlatStyle = FlatStyle.Flat;
            btClientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btClientes.ForeColor = Color.White;
            btClientes.Location = new Point(22, 172);
            btClientes.Margin = new Padding(3, 4, 3, 4);
            btClientes.Name = "btClientes";
            btClientes.Size = new Size(300, 41);
            btClientes.TabIndex = 4;
            btClientes.Text = "Gestionar Clientes";
            btClientes.TextColor = Color.White;
            btClientes.UseVisualStyleBackColor = false;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRedondeado1.AutoSize = true;
            panelRedondeado1.BackColor = Color.MediumVioletRed;
            panelRedondeado1.BorderRadius = 80;
            panelRedondeado1.Controls.Add(btClientes);
            panelRedondeado1.Controls.Add(btAutor);
            panelRedondeado1.Controls.Add(btEmpleados);
            panelRedondeado1.Location = new Point(277, 80);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.RightToLeft = RightToLeft.Yes;
            panelRedondeado1.Size = new Size(345, 372);
            panelRedondeado1.TabIndex = 5;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Segoe UI", 20F);
            lblBienvenido.Location = new Point(354, 20);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(205, 46);
            lblBienvenido.TabIndex = 6;
            lblBienvenido.Text = "¡Bienvenido!";
            // 
            // btSalirSistema
            // 
            btSalirSistema.AutoSize = true;
            btSalirSistema.BackColor = Color.Black;
            btSalirSistema.BackgroundColor = Color.Black;
            btSalirSistema.BorderColor = Color.DeepPink;
            btSalirSistema.BorderRadius = 40;
            btSalirSistema.BorderSize = 3;
            btSalirSistema.FlatAppearance.BorderSize = 0;
            btSalirSistema.FlatStyle = FlatStyle.Flat;
            btSalirSistema.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSalirSistema.ForeColor = Color.White;
            btSalirSistema.Location = new Point(748, 537);
            btSalirSistema.Margin = new Padding(3, 4, 3, 4);
            btSalirSistema.Name = "btSalirSistema";
            btSalirSistema.Size = new Size(129, 41);
            btSalirSistema.TabIndex = 5;
            btSalirSistema.Text = "Salir";
            btSalirSistema.TextColor = Color.White;
            btSalirSistema.UseVisualStyleBackColor = false;
            btSalirSistema.Click += btSalirSistema_Click_1;
            // 
            // Menudeinicio
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Pink;
            ClientSize = new Size(914, 600);
            Controls.Add(btSalirSistema);
            Controls.Add(lblBienvenido);
            Controls.Add(panelRedondeado1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menudeinicio";
            Text = "Menudeinicio";
            Paint += Menudeinicio_Paint;
            Resize += Menudeinicio_Resize;
            panelRedondeado1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomLabel customLabel1;
        private Boton btEmpleados;
        private Boton btAutor;
        private Boton btClientes;
        private PanelRedondeado panelRedondeado1;
        private CustomLabel lblBienvenido;
        private Boton btSalirSistema;
    }
}