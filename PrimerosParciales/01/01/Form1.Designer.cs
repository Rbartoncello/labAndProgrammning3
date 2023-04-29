using Entidades;
namespace _01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtMarca = new TextBox();
            btnAgregar = new Button();
            txtPatente = new TextBox();
            txtNombreEstacionamiento = new TextBox();
            lstVehiculos = new ListBox();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoVehiculo.Location = new Point(30, 90);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(81, 15);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatente.Location = new Point(30, 126);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(51, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(30, 159);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(64, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo Moto";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(137, 82);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 3;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(137, 156);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(264, 156);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(24, 358);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(175, 81);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(137, 123);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 5;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(449, 25);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(316, 23);
            txtNombreEstacionamiento.TabIndex = 8;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(449, 82);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(316, 349);
            lstVehiculos.TabIndex = 10;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lstVehiculos);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(btnAgregar);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtMarca;
        private Button btnAgregar;
        private TextBox txtPatente;
        private TextBox txtNombreEstacionamiento;
        private Estacionamiento estacionamiento;
        private ListBox lstVehiculos;
    }
}