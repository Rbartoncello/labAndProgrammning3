namespace Exercise_23
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblEuro = new TextBox();
            lblDolar = new TextBox();
            lblPeso = new TextBox();
            lblEuroA = new TextBox();
            lblDolarA = new TextBox();
            lblPesoA = new TextBox();
            lblCotizacion = new TextBox();
            txtPeso = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtEuroAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAEuro = new TextBox();
            txtDolarADolar = new TextBox();
            txtDolarAPeso = new TextBox();
            txtPesoAEuro = new TextBox();
            txtPesoADolar = new TextBox();
            txtPesoAPeso = new TextBox();
            btnLockCotizacion = new Button();
            imageList1 = new ImageList(components);
            txtCotizacionEuro = new TextBox();
            txtCotizacionDolar = new TextBox();
            txtCotizacionPeso = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // lblEuro
            // 
            lblEuro.BackColor = SystemColors.ControlDarkDark;
            lblEuro.BorderStyle = BorderStyle.None;
            lblEuro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro.ForeColor = SystemColors.WindowText;
            lblEuro.Location = new Point(23, 247);
            lblEuro.Name = "lblEuro";
            lblEuro.ReadOnly = true;
            lblEuro.Size = new Size(80, 36);
            lblEuro.TabIndex = 0;
            lblEuro.Text = "Euro";
            lblEuro.WordWrap = false;
            // 
            // lblDolar
            // 
            lblDolar.BackColor = SystemColors.ControlDarkDark;
            lblDolar.BorderStyle = BorderStyle.None;
            lblDolar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar.Location = new Point(23, 300);
            lblDolar.Name = "lblDolar";
            lblDolar.ReadOnly = true;
            lblDolar.Size = new Size(80, 36);
            lblDolar.TabIndex = 1;
            lblDolar.Text = "Dolar";
            lblDolar.WordWrap = false;
            // 
            // lblPeso
            // 
            lblPeso.BackColor = SystemColors.ControlDarkDark;
            lblPeso.BorderStyle = BorderStyle.None;
            lblPeso.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(23, 353);
            lblPeso.Name = "lblPeso";
            lblPeso.ReadOnly = true;
            lblPeso.Size = new Size(80, 36);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso";
            lblPeso.WordWrap = false;
            // 
            // lblEuroA
            // 
            lblEuroA.BackColor = SystemColors.ControlDarkDark;
            lblEuroA.BorderStyle = BorderStyle.None;
            lblEuroA.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuroA.Location = new Point(370, 194);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.ReadOnly = true;
            lblEuroA.Size = new Size(140, 36);
            lblEuroA.TabIndex = 3;
            lblEuroA.Text = "Euro";
            lblEuroA.TextAlign = HorizontalAlignment.Center;
            lblEuroA.WordWrap = false;
            // 
            // lblDolarA
            // 
            lblDolarA.BackColor = SystemColors.ControlDarkDark;
            lblDolarA.BorderStyle = BorderStyle.None;
            lblDolarA.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolarA.Location = new Point(540, 194);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.ReadOnly = true;
            lblDolarA.Size = new Size(140, 36);
            lblDolarA.TabIndex = 4;
            lblDolarA.Text = "Dolar";
            lblDolarA.TextAlign = HorizontalAlignment.Center;
            lblDolarA.WordWrap = false;
            // 
            // lblPesoA
            // 
            lblPesoA.BackColor = SystemColors.ControlDarkDark;
            lblPesoA.BorderStyle = BorderStyle.None;
            lblPesoA.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoA.Location = new Point(710, 194);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.ReadOnly = true;
            lblPesoA.Size = new Size(140, 36);
            lblPesoA.TabIndex = 5;
            lblPesoA.Text = "Peso";
            lblPesoA.TextAlign = HorizontalAlignment.Center;
            lblPesoA.WordWrap = false;
            // 
            // lblCotizacion
            // 
            lblCotizacion.BackColor = SystemColors.ControlDarkDark;
            lblCotizacion.BorderStyle = BorderStyle.None;
            lblCotizacion.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(120, 150);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.ReadOnly = true;
            lblCotizacion.Size = new Size(140, 36);
            lblCotizacion.TabIndex = 6;
            lblCotizacion.Text = "Cotizacion";
            lblCotizacion.WordWrap = false;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(120, 366);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(140, 23);
            txtPeso.TabIndex = 7;
            txtPeso.KeyPress += txtCotizacionEuro_KeyPress;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(120, 313);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(140, 23);
            txtDolar.TabIndex = 8;
            txtDolar.KeyPress += txtCotizacionEuro_KeyPress;
            txtDolar.Leave += txtDolar_Leave;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(120, 260);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(140, 23);
            txtEuro.TabIndex = 9;
            txtEuro.KeyPress += txtCotizacionEuro_KeyPress;
            txtEuro.Leave += txtEuro_Leave;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(290, 247);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(50, 36);
            btnConvertEuro.TabIndex = 10;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(290, 300);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(50, 36);
            btnConvertDolar.TabIndex = 11;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(290, 353);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(50, 36);
            btnConvertPeso.TabIndex = 12;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(370, 260);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.ReadOnly = true;
            txtEuroAEuro.Size = new Size(140, 23);
            txtEuroAEuro.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(540, 260);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.ReadOnly = true;
            txtEuroADolar.Size = new Size(140, 23);
            txtEuroADolar.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(710, 260);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.ReadOnly = true;
            txtEuroAPeso.Size = new Size(140, 23);
            txtEuroAPeso.TabIndex = 15;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(370, 315);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.ReadOnly = true;
            txtDolarAEuro.Size = new Size(140, 23);
            txtDolarAEuro.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(540, 315);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.ReadOnly = true;
            txtDolarADolar.Size = new Size(140, 23);
            txtDolarADolar.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(710, 315);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.ReadOnly = true;
            txtDolarAPeso.Size = new Size(140, 23);
            txtDolarAPeso.TabIndex = 18;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new Point(370, 368);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.ReadOnly = true;
            txtPesoAEuro.Size = new Size(140, 23);
            txtPesoAEuro.TabIndex = 19;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new Point(540, 368);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.ReadOnly = true;
            txtPesoADolar.Size = new Size(140, 23);
            txtPesoADolar.TabIndex = 20;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new Point(710, 368);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.ReadOnly = true;
            txtPesoAPeso.Size = new Size(140, 23);
            txtPesoAPeso.TabIndex = 21;
            // 
            // btnLockCotizacion
            // 
            btnLockCotizacion.ImageIndex = 0;
            btnLockCotizacion.ImageList = imageList1;
            btnLockCotizacion.Location = new Point(290, 150);
            btnLockCotizacion.Name = "btnLockCotizacion";
            btnLockCotizacion.RightToLeft = RightToLeft.Yes;
            btnLockCotizacion.Size = new Size(50, 50);
            btnLockCotizacion.TabIndex = 22;
            btnLockCotizacion.UseVisualStyleBackColor = true;
            btnLockCotizacion.Click += btnLockCotizacion_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "lock_open_icon.png");
            imageList1.Images.SetKeyName(1, "lock_ico.png");
            // 
            // txtCotizacionEuro
            // 
            txtCotizacionEuro.Location = new Point(370, 160);
            txtCotizacionEuro.Name = "txtCotizacionEuro";
            txtCotizacionEuro.Size = new Size(140, 23);
            txtCotizacionEuro.TabIndex = 23;
            txtCotizacionEuro.KeyPress += txtCotizacionEuro_KeyPress;
            txtCotizacionEuro.Leave += txtCotizacionEuro_Leave;
            // 
            // txtCotizacionDolar
            // 
            txtCotizacionDolar.Enabled = false;
            txtCotizacionDolar.Location = new Point(540, 160);
            txtCotizacionDolar.Name = "txtCotizacionDolar";
            txtCotizacionDolar.ReadOnly = true;
            txtCotizacionDolar.Size = new Size(140, 23);
            txtCotizacionDolar.TabIndex = 24;
            txtCotizacionDolar.Text = "1";
            // 
            // txtCotizacionPeso
            // 
            txtCotizacionPeso.Location = new Point(710, 160);
            txtCotizacionPeso.Name = "txtCotizacionPeso";
            txtCotizacionPeso.Size = new Size(140, 23);
            txtCotizacionPeso.TabIndex = 25;
            txtCotizacionPeso.KeyPress += txtCotizacionEuro_KeyPress;
            txtCotizacionPeso.Leave += txtCotizacionPeso_Leave;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(910, 450);
            Controls.Add(txtCotizacionPeso);
            Controls.Add(txtCotizacionDolar);
            Controls.Add(txtCotizacionEuro);
            Controls.Add(btnLockCotizacion);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtEuroAEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtPeso);
            Controls.Add(lblCotizacion);
            Controls.Add(lblPesoA);
            Controls.Add(lblDolarA);
            Controls.Add(lblEuroA);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblEuro;
        private TextBox lblDolar;
        private TextBox lblPeso;
        private TextBox lblEuroA;
        private TextBox lblDolarA;
        private TextBox lblPesoA;
        private TextBox lblCotizacion;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAEuro;
        private TextBox txtDolarADolar;
        private TextBox txtDolarAPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtPesoAPeso;
        private Button btnLockCotizacion;
        private TextBox txtCotizacionEuro;
        private TextBox txtCotizacionDolar;
        private TextBox txtCotizacionPeso;
        private ContextMenuStrip contextMenuStrip1;
        private ImageList imageList1;
    }
}