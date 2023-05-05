using Entidades;
namespace _03
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
            cmbGrupo = new ComboBox();
            cmbTipo = new ComboBox();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            dtpHoraIngreso = new DateTimePicker();
            lstEmpleados = new ListBox();
            btnImpNomina = new Button();
            btnIngresoEmp = new Button();
            btnEgresoEmp = new Button();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblTipo = new Label();
            lblHoraIngreso = new Label();
            lblGrupo = new Label();
            SuspendLayout();
            // 
            // cmbGrupo
            // 
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(57, 122);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(121, 23);
            cmbGrupo.TabIndex = 2;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(391, 56);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 3;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(244, 56);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // dtpHoraIngreso
            // 
            dtpHoraIngreso.Format = DateTimePickerFormat.Time;
            dtpHoraIngreso.Location = new Point(572, 56);
            dtpHoraIngreso.Name = "dtpHoraIngreso";
            dtpHoraIngreso.Size = new Size(128, 23);
            dtpHoraIngreso.TabIndex = 4;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(57, 238);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(545, 139);
            lstEmpleados.TabIndex = 5;
            // 
            // btnImpNomina
            // 
            btnImpNomina.Location = new Point(667, 298);
            btnImpNomina.Name = "btnImpNomina";
            btnImpNomina.Size = new Size(124, 59);
            btnImpNomina.TabIndex = 6;
            btnImpNomina.Text = "Imprimir Nomina";
            btnImpNomina.UseVisualStyleBackColor = true;
            // 
            // btnIngresoEmp
            // 
            btnIngresoEmp.Location = new Point(57, 173);
            btnIngresoEmp.Name = "btnIngresoEmp";
            btnIngresoEmp.Size = new Size(105, 25);
            btnIngresoEmp.TabIndex = 7;
            btnIngresoEmp.Text = "Ingreso";
            btnIngresoEmp.UseVisualStyleBackColor = true;
            btnIngresoEmp.Click += btnIngresoEmp_Click;
            // 
            // btnEgresoEmp
            // 
            btnEgresoEmp.Location = new Point(497, 173);
            btnEgresoEmp.Name = "btnEgresoEmp";
            btnEgresoEmp.Size = new Size(105, 25);
            btnEgresoEmp.TabIndex = 8;
            btnEgresoEmp.Text = "Retiro";
            btnEgresoEmp.UseVisualStyleBackColor = true;
            btnEgresoEmp.Click += btnEgresoEmp_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(64, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(244, 35);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 10;
            lblLegajo.Text = "Legajo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(391, 38);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(572, 35);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(75, 15);
            lblHoraIngreso.TabIndex = 12;
            lblHoraIngreso.Text = "Hora Ingreso";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(57, 104);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(66, 15);
            lblGrupo.TabIndex = 13;
            lblGrupo.Text = "Grupo RAC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGrupo);
            Controls.Add(lblHoraIngreso);
            Controls.Add(lblTipo);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Controls.Add(btnEgresoEmp);
            Controls.Add(btnIngresoEmp);
            Controls.Add(btnImpNomina);
            Controls.Add(lstEmpleados);
            Controls.Add(dtpHoraIngreso);
            Controls.Add(cmbTipo);
            Controls.Add(cmbGrupo);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImpNomina;
        private Button btnIngresoEmp;
        private Button btnEgresoEmp;
        private CentroDeAtencion centro;
        private ComboBox cmbGrupo;
        private ComboBox cmbTipo;
        private DateTimePicker dtpHoraIngreso;
        private ListBox lstEmpleados;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblTipo;
        private Label lblHoraIngreso;
        private Label lblGrupo;
    }
}