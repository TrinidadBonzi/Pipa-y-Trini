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
            tabControlPrincipal = new TabControl();
            tabListado = new TabPage();
            dgvListadoAutores = new DataGridView();
            tabAlta = new TabPage();
            btnGuardar = new Button();
            tbBiografiaAlta = new TextBox();
            lbBiografiaAlta = new Label();
            lbEmailAlta = new Label();
            tbEmailAlta = new TextBox();
            lbNacionalidadAlta = new Label();
            tbNacionalidadAlta = new TextBox();
            lbTelefonoAlta = new Label();
            tbTelefonoAlta = new TextBox();
            lbApellidoAlta = new Label();
            tbApellidoAlta = new TextBox();
            lblNombreAlta = new Label();
            tbNombreAlta = new TextBox();
            tabModificacion = new TabPage();
            tabBaja = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            tabAlta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Controls.Add(tabBaja);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(867, 486);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListadoAutores);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(859, 458);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.Location = new Point(3, 3);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.Size = new Size(850, 452);
            dgvListadoAutores.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(btnGuardar);
            tabAlta.Controls.Add(tbBiografiaAlta);
            tabAlta.Controls.Add(lbBiografiaAlta);
            tabAlta.Controls.Add(lbEmailAlta);
            tabAlta.Controls.Add(tbEmailAlta);
            tabAlta.Controls.Add(lbNacionalidadAlta);
            tabAlta.Controls.Add(tbNacionalidadAlta);
            tabAlta.Controls.Add(lbTelefonoAlta);
            tabAlta.Controls.Add(tbTelefonoAlta);
            tabAlta.Controls.Add(lbApellidoAlta);
            tabAlta.Controls.Add(tbApellidoAlta);
            tabAlta.Controls.Add(lblNombreAlta);
            tabAlta.Controls.Add(tbNombreAlta);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(859, 458);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(316, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Location = new Point(148, 195);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(416, 127);
            tbBiografiaAlta.TabIndex = 5;
            // 
            // lbBiografiaAlta
            // 
            lbBiografiaAlta.AutoSize = true;
            lbBiografiaAlta.Location = new Point(65, 198);
            lbBiografiaAlta.Name = "lbBiografiaAlta";
            lbBiografiaAlta.Size = new Size(54, 15);
            lbBiografiaAlta.TabIndex = 10;
            lbBiografiaAlta.Text = "Biografia";
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(65, 136);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(36, 15);
            lbEmailAlta.TabIndex = 9;
            lbEmailAlta.Text = "Email";
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(148, 133);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(158, 23);
            tbEmailAlta.TabIndex = 3;
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(65, 89);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(77, 15);
            lbNacionalidadAlta.TabIndex = 7;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(148, 86);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(158, 23);
            tbNacionalidadAlta.TabIndex = 2;
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(339, 136);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(52, 15);
            lbTelefonoAlta.TabIndex = 5;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(406, 133);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(158, 23);
            tbTelefonoAlta.TabIndex = 4;
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(340, 40);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(51, 15);
            lbApellidoAlta.TabIndex = 3;
            lbApellidoAlta.Text = "Apellido";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(406, 37);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(158, 23);
            tbApellidoAlta.TabIndex = 1;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(65, 40);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(51, 15);
            lblNombreAlta.TabIndex = 1;
            lblNombreAlta.Text = "Nombre";
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(148, 40);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(158, 23);
            tbNombreAlta.TabIndex = 0;
            // 
            // tabModificacion
            // 
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(859, 458);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // tabBaja
            // 
            tabBaja.Location = new Point(4, 24);
            tabBaja.Name = "tabBaja";
            tabBaja.Padding = new Padding(3);
            tabBaja.Size = new Size(859, 458);
            tabBaja.TabIndex = 3;
            tabBaja.Text = "Baja";
            tabBaja.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(tabControlPrincipal);
            Name = "ABMAutor";
            Text = "ABMAutor";
            Load += ABMAutor_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            tabAlta.ResumeLayout(false);
            tabAlta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabModificacion;
        private TabPage tabBaja;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvListadoAutores;
        private TabPage tabAlta;
        private Label lbEmailAlta;
        private TextBox tbEmailAlta;
        private Label lbNacionalidadAlta;
        private TextBox tbNacionalidadAlta;
        private Label lbTelefonoAlta;
        private TextBox tbTelefonoAlta;
        private Label lbApellidoAlta;
        private TextBox tbApellidoAlta;
        private Label lblNombreAlta;
        private TextBox tbNombreAlta;
        private Label lbBiografiaAlta;
        private TextBox tbBiografiaAlta;
        private Button btnGuardar;
    }
}