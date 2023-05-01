using Entidades;
namespace _02
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
            cmbEquipoUno = new ComboBox();
            cmbEquipoDos = new ComboBox();
            btnDesafiar = new Button();
            dgvResultados = new DataGridView();
            rchtDatosTorneo = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            cmbEquipoUno.FormattingEnabled = true;
            cmbEquipoUno.Location = new Point(29, 31);
            cmbEquipoUno.Name = "cmbEquipoUno";
            cmbEquipoUno.Size = new Size(350, 23);
            cmbEquipoUno.TabIndex = 0;
            cmbEquipoUno.SelectedIndexChanged += cmbEquipoUno_SelectedIndexChanged;
            // 
            // cmbEquipoDos
            // 
            cmbEquipoDos.FormattingEnabled = true;
            cmbEquipoDos.Location = new Point(437, 31);
            cmbEquipoDos.Name = "cmbEquipoDos";
            cmbEquipoDos.Size = new Size(350, 23);
            cmbEquipoDos.TabIndex = 1;
            // 
            // btnDesafiar
            // 
            btnDesafiar.Location = new Point(204, 86);
            btnDesafiar.Name = "btnDesafiar";
            btnDesafiar.Size = new Size(408, 23);
            btnDesafiar.TabIndex = 2;
            btnDesafiar.Text = "Jugar";
            btnDesafiar.UseVisualStyleBackColor = true;
            btnDesafiar.Click += btnDesafiar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(29, 124);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowTemplate.Height = 25;
            dgvResultados.Size = new Size(758, 150);
            dgvResultados.TabIndex = 3;
            // 
            // rchtDatosTorneo
            // 
            rchtDatosTorneo.Location = new Point(29, 280);
            rchtDatosTorneo.Name = "rchtDatosTorneo";
            rchtDatosTorneo.Size = new Size(758, 158);
            rchtDatosTorneo.TabIndex = 4;
            rchtDatosTorneo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rchtDatosTorneo);
            Controls.Add(dgvResultados);
            Controls.Add(btnDesafiar);
            Controls.Add(cmbEquipoDos);
            Controls.Add(cmbEquipoUno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipoUno;
        private ComboBox cmbEquipoDos;
        private Button btnDesafiar;
        private DataGridView dgvResultados;
        private RichTextBox rchtDatosTorneo;
        private Competencia competencia;
    }
}