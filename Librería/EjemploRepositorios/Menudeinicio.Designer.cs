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
            label1 = new Label();
            btSalirSistema = new Boton();
            btAutor = new Boton();
            btEmpleados = new Boton();
            btClientes = new Boton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 36);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido!";
            // 
            // btSalirSistema
            // 
            btSalirSistema.BackColor = Color.Black;
            btSalirSistema.BackgroundColor = Color.Black;
            btSalirSistema.BorderColor = Color.DeepPink;
            btSalirSistema.BorderRadius = 40;
            btSalirSistema.BorderSize = 3;
            btSalirSistema.FlatAppearance.BorderSize = 0;
            btSalirSistema.FlatStyle = FlatStyle.Flat;
            btSalirSistema.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSalirSistema.ForeColor = Color.White;
            btSalirSistema.Location = new Point(694, 406);
            btSalirSistema.Name = "btSalirSistema";
            btSalirSistema.Size = new Size(96, 36);
            btSalirSistema.TabIndex = 1;
            btSalirSistema.Text = "Salir";
            btSalirSistema.TextColor = Color.White;
            btSalirSistema.UseVisualStyleBackColor = false;
            btSalirSistema.Click += btSalirSistema_Click;
            // 
            // btAutor
            // 
            btAutor.BackColor = Color.Black;
            btAutor.BackgroundColor = Color.Black;
            btAutor.BorderColor = Color.DeepPink;
            btAutor.BorderRadius = 40;
            btAutor.BorderSize = 3;
            btAutor.FlatAppearance.BorderSize = 0;
            btAutor.FlatStyle = FlatStyle.Flat;
            btAutor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAutor.ForeColor = Color.White;
            btAutor.Location = new Point(293, 87);
            btAutor.Name = "btAutor";
            btAutor.Size = new Size(204, 31);
            btAutor.TabIndex = 2;
            btAutor.Text = "Gestionar Autores";
            btAutor.TextColor = Color.White;
            btAutor.UseVisualStyleBackColor = false;
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
            btEmpleados.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEmpleados.ForeColor = Color.White;
            btEmpleados.Location = new Point(293, 141);
            btEmpleados.Name = "btEmpleados";
            btEmpleados.Size = new Size(204, 31);
            btEmpleados.TabIndex = 3;
            btEmpleados.Text = "Gestionar Empleados";
            btEmpleados.TextColor = Color.White;
            btEmpleados.UseVisualStyleBackColor = false;
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
            btClientes.Location = new Point(293, 194);
            btClientes.Name = "btClientes";
            btClientes.Size = new Size(204, 31);
            btClientes.TabIndex = 4;
            btClientes.Text = "Gestionar Clientes";
            btClientes.TextColor = Color.White;
            btClientes.UseVisualStyleBackColor = false;
            // 
            // Menudeinicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btClientes);
            Controls.Add(btEmpleados);
            Controls.Add(btAutor);
            Controls.Add(btSalirSistema);
            Controls.Add(label1);
            Name = "Menudeinicio";
            Text = "Menudeinicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Boton btSalirSistema;
        private Boton btAutor;
        private Boton btEmpleados;
        private Boton btClientes;
    }
}