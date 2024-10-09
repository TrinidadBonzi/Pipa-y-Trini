namespace CPresentacion
{
    partial class ABMAutor
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
            lbNombre = new Label();
            lbApellido = new Label();
            lbNacionalidad = new Label();
            lbEmail = new Label();
            lbTelefono = new Label();
            lbBiografia = new Label();
            tbNombreAlta = new TextBox();
            tbApellidoAlta = new TextBox();
            tbNacionalidadAlta = new TextBox();
            tbEmailAlta = new TextBox();
            tbTelefonoAlta = new TextBox();
            tbBiografiaAlta = new TextBox();
            btGuardar = new Button();
            btModificar = new Button();
            btEliminar = new Button();
            dgvListadoAutores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(20, 40);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(57, 23);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(20, 70);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(58, 23);
            lbApellido.TabIndex = 1;
            lbApellido.Text = "Apellido:";
            // 
            // lbNacionalidad
            // 
            lbNacionalidad.AutoSize = true;
            lbNacionalidad.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNacionalidad.Location = new Point(21, 100);
            lbNacionalidad.Name = "lbNacionalidad";
            lbNacionalidad.Size = new Size(83, 23);
            lbNacionalidad.TabIndex = 2;
            lbNacionalidad.Text = "Nacionalidad:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(21, 132);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(43, 23);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefono.Location = new Point(21, 164);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(61, 23);
            lbTelefono.TabIndex = 4;
            lbTelefono.Text = "Telefono:";
            // 
            // lbBiografia
            // 
            lbBiografia.AutoSize = true;
            lbBiografia.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBiografia.Location = new Point(275, 40);
            lbBiografia.Name = "lbBiografia";
            lbBiografia.Size = new Size(62, 23);
            lbBiografia.TabIndex = 5;
            lbBiografia.Text = "Biografia:";
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(83, 40);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(147, 23);
            tbNombreAlta.TabIndex = 6;
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(84, 71);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(147, 23);
            tbApellidoAlta.TabIndex = 7;
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(110, 100);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(147, 23);
            tbNacionalidadAlta.TabIndex = 8;
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(70, 133);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(187, 23);
            tbEmailAlta.TabIndex = 9;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(83, 165);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(147, 23);
            tbTelefonoAlta.TabIndex = 10;
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Location = new Point(343, 44);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(296, 144);
            tbBiografiaAlta.TabIndex = 11;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.FromArgb(255, 192, 192);
            btGuardar.Font = new Font("Gloucester MT Extra Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btGuardar.Location = new Point(689, 48);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(87, 37);
            btGuardar.TabIndex = 12;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btModificar
            // 
            btModificar.BackColor = Color.FromArgb(255, 192, 192);
            btModificar.Font = new Font("Gloucester MT Extra Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btModificar.Location = new Point(689, 93);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(87, 37);
            btModificar.TabIndex = 13;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = false;
            btModificar.Click += btModificar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btEliminar.Font = new Font("Gloucester MT Extra Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(689, 140);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(87, 37);
            btEliminar.TabIndex = 14;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.GridColor = SystemColors.ActiveBorder;
            dgvListadoAutores.Location = new Point(28, 217);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.Size = new Size(740, 221);
            dgvListadoAutores.TabIndex = 15;
            dgvListadoAutores.CellContentClick += dgvListadoAutores_CellContentClick;
            dgvListadoAutores.RowHeaderMouseClick += dgvListadoAutores_RowHeaderMouseClick;
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListadoAutores);
            Controls.Add(btEliminar);
            Controls.Add(btModificar);
            Controls.Add(btGuardar);
            Controls.Add(tbBiografiaAlta);
            Controls.Add(tbTelefonoAlta);
            Controls.Add(tbEmailAlta);
            Controls.Add(tbNacionalidadAlta);
            Controls.Add(tbApellidoAlta);
            Controls.Add(tbNombreAlta);
            Controls.Add(lbBiografia);
            Controls.Add(lbTelefono);
            Controls.Add(lbEmail);
            Controls.Add(lbNacionalidad);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Name = "ABMAutor";
            Text = "ABMAutor";
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbApellido;
        private Label lbNacionalidad;
        private Label lbEmail;
        private Label lbTelefono;
        private Label lbBiografia;
        private TextBox tbNombreAlta;
        private TextBox tbApellidoAlta;
        private TextBox tbNacionalidadAlta;
        private TextBox tbEmailAlta;
        private TextBox tbTelefonoAlta;
        private TextBox tbBiografiaAlta;
        private Button btGuardar;
        private Button btModificar;
        private Button btEliminar;
        private DataGridView dgvListadoAutores;
    }
}