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
        }

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
            groupBoxAsignarMateria = new GroupBox();
            btbAsignarAlumnoSelec = new Button();
            lblMateria = new Label();
            selecMaterias = new ComboBox();
            lstAlumnosInscriptosProg = new ListBox();
            label1 = new Label();
            lstAlumnosInscriptosLab = new ListBox();
            label2 = new Label();
            groupBoxAltaAlumno = new GroupBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            txtInputNombre = new TextBox();
            txtInputApellido = new TextBox();
            numberInputDni = new TextBox();
            btnCrearAlumno = new Button();
            groupBoxAsignarMateria.SuspendLayout();
            groupBoxAltaAlumno.SuspendLayout();
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
            // groupBoxAsignarMateria
            // 
            groupBoxAsignarMateria.Controls.Add(btbAsignarAlumnoSelec);
            groupBoxAsignarMateria.Controls.Add(lblMateria);
            groupBoxAsignarMateria.Controls.Add(selecMaterias);
            resources.ApplyResources(groupBoxAsignarMateria, "groupBoxAsignarMateria");
            groupBoxAsignarMateria.Name = "groupBoxAsignarMateria";
            groupBoxAsignarMateria.TabStop = false;
            // 
            // btbAsignarAlumnoSelec
            // 
            resources.ApplyResources(btbAsignarAlumnoSelec, "btbAsignarAlumnoSelec");
            btbAsignarAlumnoSelec.Name = "btbAsignarAlumnoSelec";
            btbAsignarAlumnoSelec.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            resources.ApplyResources(lblMateria, "lblMateria");
            lblMateria.Name = "lblMateria";
            // 
            // selecMaterias
            // 
            selecMaterias.FormattingEnabled = true;
            selecMaterias.Items.AddRange(new object[] { resources.GetString("selecMaterias.Items"), resources.GetString("selecMaterias.Items1") });
            resources.ApplyResources(selecMaterias, "selecMaterias");
            selecMaterias.Name = "selecMaterias";
            // 
            // lstAlumnosInscriptosProg
            // 
            lstAlumnosInscriptosProg.FormattingEnabled = true;
            resources.ApplyResources(lstAlumnosInscriptosProg, "lstAlumnosInscriptosProg");
            lstAlumnosInscriptosProg.Name = "lstAlumnosInscriptosProg";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lstAlumnosInscriptosLab
            // 
            lstAlumnosInscriptosLab.FormattingEnabled = true;
            resources.ApplyResources(lstAlumnosInscriptosLab, "lstAlumnosInscriptosLab");
            lstAlumnosInscriptosLab.Name = "lstAlumnosInscriptosLab";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // groupBoxAltaAlumno
            // 
            groupBoxAltaAlumno.Controls.Add(lblNombre);
            groupBoxAltaAlumno.Controls.Add(lblApellido);
            groupBoxAltaAlumno.Controls.Add(lblDni);
            groupBoxAltaAlumno.Controls.Add(txtInputNombre);
            groupBoxAltaAlumno.Controls.Add(txtInputApellido);
            groupBoxAltaAlumno.Controls.Add(numberInputDni);
            groupBoxAltaAlumno.Controls.Add(btnCrearAlumno);
            resources.ApplyResources(groupBoxAltaAlumno, "groupBoxAltaAlumno");
            groupBoxAltaAlumno.Name = "groupBoxAltaAlumno";
            groupBoxAltaAlumno.TabStop = false;
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
            // txtInputNombre
            // 
            resources.ApplyResources(txtInputNombre, "txtInputNombre");
            txtInputNombre.Name = "txtInputNombre";
            // 
            // txtInputApellido
            // 
            resources.ApplyResources(txtInputApellido, "txtInputApellido");
            txtInputApellido.Name = "txtInputApellido";
            // 
            // numberInputDni
            // 
            resources.ApplyResources(numberInputDni, "numberInputDni");
            numberInputDni.Name = "numberInputDni";
            // 
            // btnCrearAlumno
            // 
            resources.ApplyResources(btnCrearAlumno, "btnCrearAlumno");
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAltaAlumno);
            Controls.Add(label2);
            Controls.Add(lstAlumnosInscriptosLab);
            Controls.Add(label1);
            Controls.Add(lstAlumnosInscriptosProg);
            Controls.Add(groupBoxAsignarMateria);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(lstAlumnosCreados);
            Name = "Form1";
            groupBoxAsignarMateria.ResumeLayout(false);
            groupBoxAsignarMateria.PerformLayout();
            groupBoxAltaAlumno.ResumeLayout(false);
            groupBoxAltaAlumno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAlumnosCreados;
        private Label lblAlumnosCreados;
        private GroupBox groupBoxAsignarMateria;
        private ComboBox selecMaterias;
        private Label lblMateria;
        private Button btbAsignarAlumnoSelec;
        private ListBox lstAlumnosInscriptosProg;
        private Label label1;
        private ListBox lstAlumnosInscriptosLab;
        private Label label2;
        private GroupBox groupBoxAltaAlumno;
        private Button btnCrearAlumno;
        private Label lblDni;
        private TextBox txtInputNombre;
        private TextBox txtInputApellido;
        private TextBox numberInputDni;
        private Label lblNombre;
        private Label lblApellido;
    }
}