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
            dgvListadoAutores = new DataGridView();
            btnGuardar = new Boton();
            btnModificar = new Boton();
            btnEliminar = new Boton();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(23, 53);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(69, 28);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(23, 93);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(71, 28);
            lbApellido.TabIndex = 1;
            lbApellido.Text = "Apellido:";
            // 
            // lbNacionalidad
            // 
            lbNacionalidad.AutoSize = true;
            lbNacionalidad.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNacionalidad.Location = new Point(24, 133);
            lbNacionalidad.Name = "lbNacionalidad";
            lbNacionalidad.Size = new Size(102, 28);
            lbNacionalidad.TabIndex = 2;
            lbNacionalidad.Text = "Nacionalidad:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(24, 176);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 28);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefono.Location = new Point(24, 219);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(75, 28);
            lbTelefono.TabIndex = 4;
            lbTelefono.Text = "Telefono:";
            // 
            // lbBiografia
            // 
            lbBiografia.AutoSize = true;
            lbBiografia.Font = new Font("Gloucester MT Extra Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBiografia.Location = new Point(314, 53);
            lbBiografia.Name = "lbBiografia";
            lbBiografia.Size = new Size(78, 28);
            lbBiografia.TabIndex = 5;
            lbBiografia.Text = "Biografia:";
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(95, 53);
            tbNombreAlta.Margin = new Padding(3, 4, 3, 4);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(167, 27);
            tbNombreAlta.TabIndex = 6;
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(96, 95);
            tbApellidoAlta.Margin = new Padding(3, 4, 3, 4);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(167, 27);
            tbApellidoAlta.TabIndex = 7;
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(126, 133);
            tbNacionalidadAlta.Margin = new Padding(3, 4, 3, 4);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(167, 27);
            tbNacionalidadAlta.TabIndex = 8;
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(80, 177);
            tbEmailAlta.Margin = new Padding(3, 4, 3, 4);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(213, 27);
            tbEmailAlta.TabIndex = 9;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(95, 220);
            tbTelefonoAlta.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(167, 27);
            tbTelefonoAlta.TabIndex = 10;
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Location = new Point(392, 59);
            tbBiografiaAlta.Margin = new Padding(3, 4, 3, 4);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(338, 191);
            tbBiografiaAlta.TabIndex = 11;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.GridColor = SystemColors.ActiveBorder;
            dgvListadoAutores.Location = new Point(32, 289);
            dgvListadoAutores.Margin = new Padding(3, 4, 3, 4);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.RowHeadersWidth = 51;
            dgvListadoAutores.Size = new Size(846, 295);
            dgvListadoAutores.TabIndex = 15;
            dgvListadoAutores.CellContentClick += dgvListadoAutores_CellContentClick;
            dgvListadoAutores.RowHeaderMouseClick += dgvListadoAutores_RowHeaderMouseClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.BackgroundColor = SystemColors.ActiveCaptionText;
            btnGuardar.BorderColor = Color.DeepPink;
            btnGuardar.BorderRadius = 45;
            btnGuardar.BorderSize = 3;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(764, 61);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 47);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaptionText;
            btnModificar.BackgroundColor = SystemColors.ActiveCaptionText;
            btnModificar.BorderColor = Color.DeepPink;
            btnModificar.BorderRadius = 45;
            btnModificar.BorderSize = 3;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(764, 133);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 47);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.TextColor = Color.White;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaptionText;
            btnEliminar.BackgroundColor = SystemColors.ActiveCaptionText;
            btnEliminar.BorderColor = Color.DeepPink;
            btnEliminar.BorderRadius = 45;
            btnEliminar.BorderSize = 3;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(764, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 47);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvListadoAutores);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridView dgvListadoAutores;
        private Boton btnGuardar;
        private Boton btnModificar;
        private Boton btnEliminar;
    }
}