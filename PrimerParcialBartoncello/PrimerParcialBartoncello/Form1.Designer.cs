using Entidades;

namespace PrimerParcialBartoncello
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
        }//
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstAlumnosCreados = new ListBox();
            lblAlumnosCreados = new Label();
            grpAsignarMateria = new GroupBox();
            btnAsignar = new Button();
            lblMateria = new Label();
            cmbMaterias = new ComboBox();
            lstAlumnosInscriptosProgramacion = new ListBox();
            label1 = new Label();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            label2 = new Label();
            grpAltaAlumno = new GroupBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnCrearAlumno = new Button();
            grpAsignarMateria.SuspendLayout();
            grpAltaAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            resources.ApplyResources(lstAlumnosCreados, "lstAlumnosCreados");
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            // 
            // lblAlumnosCreados
            // 
            resources.ApplyResources(lblAlumnosCreados, "lblAlumnosCreados");
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            // 
            // grpAsignarMateria
            // 
            grpAsignarMateria.Controls.Add(btnAsignar);
            grpAsignarMateria.Controls.Add(lblMateria);
            grpAsignarMateria.Controls.Add(cmbMaterias);
            resources.ApplyResources(grpAsignarMateria, "grpAsignarMateria");
            grpAsignarMateria.Name = "grpAsignarMateria";
            grpAsignarMateria.TabStop = false;
            // 
            // btnAsignar
            // 
            resources.ApplyResources(btnAsignar, "btnAsignar");
            btnAsignar.Name = "btnAsignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lblMateria
            // 
            resources.ApplyResources(lblMateria, "lblMateria");
            lblMateria.Name = "lblMateria";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            resources.ApplyResources(cmbMaterias, "cmbMaterias");
            cmbMaterias.Name = "cmbMaterias";
            // 
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            resources.ApplyResources(lstAlumnosInscriptosProgramacion, "lstAlumnosInscriptosProgramacion");
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            resources.ApplyResources(lstAlumnosInscriptosLaboratorio, "lstAlumnosInscriptosLaboratorio");
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // grpAltaAlumno
            // 
            grpAltaAlumno.Controls.Add(lblNombre);
            grpAltaAlumno.Controls.Add(lblApellido);
            grpAltaAlumno.Controls.Add(lblDni);
            grpAltaAlumno.Controls.Add(txtNombre);
            grpAltaAlumno.Controls.Add(txtApellido);
            grpAltaAlumno.Controls.Add(txtDni);
            grpAltaAlumno.Controls.Add(btnCrearAlumno);
            resources.ApplyResources(grpAltaAlumno, "grpAltaAlumno");
            grpAltaAlumno.Name = "grpAltaAlumno";
            grpAltaAlumno.TabStop = false;
            // 
            // lblNombre
            // 
            resources.ApplyResources(lblNombre, "lblNombre");
            lblNombre.Name = "lblNombre";
            // 
            // lblApellido
            // 
            resources.ApplyResources(lblApellido, "lblApellido");
            lblApellido.Name = "lblApellido";
            // 
            // lblDni
            // 
            resources.ApplyResources(lblDni, "lblDni");
            lblDni.Name = "lblDni";
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            // 
            // txtApellido
            // 
            resources.ApplyResources(txtApellido, "txtApellido");
            txtApellido.Name = "txtApellido";
            // 
            // txtDni
            // 
            resources.ApplyResources(txtDni, "txtDni");
            txtDni.Name = "txtDni";
            // 
            // btnCrearAlumno
            // 
            resources.ApplyResources(btnCrearAlumno, "btnCrearAlumno");
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpAltaAlumno);
            Controls.Add(label2);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(label1);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(grpAsignarMateria);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(lstAlumnosCreados);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            grpAsignarMateria.ResumeLayout(false);
            grpAsignarMateria.PerformLayout();
            grpAltaAlumno.ResumeLayout(false);
            grpAltaAlumno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Persona alumno;
        private Button btnAsignar;
        private Button btnCrearAlumno;
        private ComboBox cmbMaterias;
        private Curso cursoProgramacion;
        private Curso cursoLaboratorio;
        private GroupBox grpAltaAlumno;
        private GroupBox grpAsignarMateria;
        private Label lblAlumnosCreados;
        private Label lblApellido;
        private Label lblDni;
        private Label lblMateria;
        private Label lblNombre;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosLaboratorio;
        private ListBox lstAlumnosInscriptosProgramacion;
        private Persona profesorLabo;
        private Persona profesorProgra;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtNombre;


        private Label label1;
        private Label label2;
    }
}