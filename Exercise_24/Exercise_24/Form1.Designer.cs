namespace Exercise_24
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
            lblFahrenheitA = new TextBox();
            lblCelsiusA = new TextBox();
            lblKelvinA = new TextBox();
            txtFahrenheit = new TextBox();
            txtCelsius = new TextBox();
            txtKelvin = new TextBox();
            btnConversionFahrenheit = new Button();
            btnConversionCelsius = new Button();
            btnConversionKelvin = new Button();
            lblFahrenhait = new TextBox();
            lblCelsius = new TextBox();
            lblKelvin = new TextBox();
            txtFahrenhaitToFahrenhait = new TextBox();
            txtFahrenhaitToCelsius = new TextBox();
            txtFahrenhaitToKelvin = new TextBox();
            txtCelsiusToFahrenhait = new TextBox();
            txtKelvinToFahrenhait = new TextBox();
            txtCelsiusToCelsius = new TextBox();
            txtCelsiusToKelvin = new TextBox();
            txtKelvinToCelsius = new TextBox();
            txtKelvinToKelvin = new TextBox();
            SuspendLayout();
            // 
            // lblFahrenheitA
            // 
            lblFahrenheitA.BackColor = SystemColors.ActiveCaption;
            lblFahrenheitA.BorderStyle = BorderStyle.None;
            lblFahrenheitA.Enabled = false;
            lblFahrenheitA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFahrenheitA.Location = new Point(30, 110);
            lblFahrenheitA.Name = "lblFahrenheitA";
            lblFahrenheitA.ReadOnly = true;
            lblFahrenheitA.Size = new Size(110, 26);
            lblFahrenheitA.TabIndex = 0;
            lblFahrenheitA.Text = "Fahrenheit";
            // 
            // lblCelsiusA
            // 
            lblCelsiusA.BackColor = SystemColors.ActiveCaption;
            lblCelsiusA.BorderStyle = BorderStyle.None;
            lblCelsiusA.Enabled = false;
            lblCelsiusA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCelsiusA.Location = new Point(30, 160);
            lblCelsiusA.Name = "lblCelsiusA";
            lblCelsiusA.ReadOnly = true;
            lblCelsiusA.Size = new Size(110, 26);
            lblCelsiusA.TabIndex = 1;
            lblCelsiusA.Text = "Celsius";
            // 
            // lblKelvinA
            // 
            lblKelvinA.BackColor = SystemColors.ActiveCaption;
            lblKelvinA.BorderStyle = BorderStyle.None;
            lblKelvinA.Enabled = false;
            lblKelvinA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKelvinA.Location = new Point(30, 210);
            lblKelvinA.Name = "lblKelvinA";
            lblKelvinA.ReadOnly = true;
            lblKelvinA.Size = new Size(110, 26);
            lblKelvinA.TabIndex = 2;
            lblKelvinA.Text = "Kelvin";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(170, 113);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(100, 23);
            txtFahrenheit.TabIndex = 3;
            txtFahrenheit.KeyPress += txtTemperature_KeyPress;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(170, 163);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 4;
            txtCelsius.KeyPress += txtTemperature_KeyPress;
            // 
            // txtKelvin
            // 
            txtKelvin.Location = new Point(170, 213);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(100, 23);
            txtKelvin.TabIndex = 5;
            txtKelvin.KeyPress += txtTemperature_KeyPress;
            // 
            // btnConversionFahrenheit
            // 
            btnConversionFahrenheit.Location = new Point(300, 110);
            btnConversionFahrenheit.Name = "btnConversionFahrenheit";
            btnConversionFahrenheit.Size = new Size(30, 26);
            btnConversionFahrenheit.TabIndex = 6;
            btnConversionFahrenheit.Text = "->";
            btnConversionFahrenheit.UseVisualStyleBackColor = true;
            btnConversionFahrenheit.Click += btnConversionFahrenheit_Click;
            // 
            // btnConversionCelsius
            // 
            btnConversionCelsius.Location = new Point(300, 160);
            btnConversionCelsius.Name = "btnConversionCelsius";
            btnConversionCelsius.Size = new Size(30, 26);
            btnConversionCelsius.TabIndex = 7;
            btnConversionCelsius.Text = "->";
            btnConversionCelsius.UseVisualStyleBackColor = true;
            btnConversionCelsius.Click += btnConversionCelsius_Click;
            // 
            // btnConversionKelvin
            // 
            btnConversionKelvin.Location = new Point(300, 210);
            btnConversionKelvin.Name = "btnConversionKelvin";
            btnConversionKelvin.Size = new Size(30, 26);
            btnConversionKelvin.TabIndex = 8;
            btnConversionKelvin.Text = "->";
            btnConversionKelvin.UseVisualStyleBackColor = true;
            btnConversionKelvin.Click += btnConversionKelvin_Click;
            // 
            // lblFahrenhait
            // 
            lblFahrenhait.BackColor = SystemColors.ActiveCaption;
            lblFahrenhait.BorderStyle = BorderStyle.None;
            lblFahrenhait.Enabled = false;
            lblFahrenhait.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFahrenhait.Location = new Point(360, 70);
            lblFahrenhait.Name = "lblFahrenhait";
            lblFahrenhait.ReadOnly = true;
            lblFahrenhait.Size = new Size(110, 26);
            lblFahrenhait.TabIndex = 9;
            lblFahrenhait.Text = "Fahrenheit";
            lblFahrenhait.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCelsius
            // 
            lblCelsius.BackColor = SystemColors.ActiveCaption;
            lblCelsius.BorderStyle = BorderStyle.None;
            lblCelsius.Enabled = false;
            lblCelsius.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCelsius.Location = new Point(500, 70);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.ReadOnly = true;
            lblCelsius.Size = new Size(110, 26);
            lblCelsius.TabIndex = 10;
            lblCelsius.Text = "Celsius";
            lblCelsius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblKelvin
            // 
            lblKelvin.BackColor = SystemColors.ActiveCaption;
            lblKelvin.BorderStyle = BorderStyle.None;
            lblKelvin.Enabled = false;
            lblKelvin.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKelvin.ForeColor = Color.Red;
            lblKelvin.Location = new Point(630, 70);
            lblKelvin.Name = "lblKelvin";
            lblKelvin.ReadOnly = true;
            lblKelvin.Size = new Size(110, 26);
            lblKelvin.TabIndex = 11;
            lblKelvin.Text = "Kelvin";
            lblKelvin.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFahrenhaitToFahrenhait
            // 
            txtFahrenhaitToFahrenhait.Enabled = false;
            txtFahrenhaitToFahrenhait.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFahrenhaitToFahrenhait.Location = new Point(360, 113);
            txtFahrenhaitToFahrenhait.Name = "txtFahrenhaitToFahrenhait";
            txtFahrenhaitToFahrenhait.ReadOnly = true;
            txtFahrenhaitToFahrenhait.Size = new Size(110, 25);
            txtFahrenhaitToFahrenhait.TabIndex = 12;
            // 
            // txtFahrenhaitToCelsius
            // 
            txtFahrenhaitToCelsius.Enabled = false;
            txtFahrenhaitToCelsius.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFahrenhaitToCelsius.Location = new Point(500, 116);
            txtFahrenhaitToCelsius.Name = "txtFahrenhaitToCelsius";
            txtFahrenhaitToCelsius.ReadOnly = true;
            txtFahrenhaitToCelsius.Size = new Size(110, 25);
            txtFahrenhaitToCelsius.TabIndex = 13;
            // 
            // txtFahrenhaitToKelvin
            // 
            txtFahrenhaitToKelvin.Enabled = false;
            txtFahrenhaitToKelvin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFahrenhaitToKelvin.Location = new Point(630, 116);
            txtFahrenhaitToKelvin.Name = "txtFahrenhaitToKelvin";
            txtFahrenhaitToKelvin.ReadOnly = true;
            txtFahrenhaitToKelvin.Size = new Size(110, 25);
            txtFahrenhaitToKelvin.TabIndex = 14;
            // 
            // txtCelsiusToFahrenhait
            // 
            txtCelsiusToFahrenhait.Enabled = false;
            txtCelsiusToFahrenhait.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelsiusToFahrenhait.Location = new Point(360, 163);
            txtCelsiusToFahrenhait.Name = "txtCelsiusToFahrenhait";
            txtCelsiusToFahrenhait.ReadOnly = true;
            txtCelsiusToFahrenhait.Size = new Size(110, 25);
            txtCelsiusToFahrenhait.TabIndex = 15;
            // 
            // txtKelvinToFahrenhait
            // 
            txtKelvinToFahrenhait.Enabled = false;
            txtKelvinToFahrenhait.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKelvinToFahrenhait.Location = new Point(360, 213);
            txtKelvinToFahrenhait.Name = "txtKelvinToFahrenhait";
            txtKelvinToFahrenhait.ReadOnly = true;
            txtKelvinToFahrenhait.Size = new Size(110, 25);
            txtKelvinToFahrenhait.TabIndex = 16;
            // 
            // txtCelsiusToCelsius
            // 
            txtCelsiusToCelsius.Enabled = false;
            txtCelsiusToCelsius.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelsiusToCelsius.Location = new Point(500, 163);
            txtCelsiusToCelsius.Name = "txtCelsiusToCelsius";
            txtCelsiusToCelsius.ReadOnly = true;
            txtCelsiusToCelsius.Size = new Size(110, 25);
            txtCelsiusToCelsius.TabIndex = 17;
            // 
            // txtCelsiusToKelvin
            // 
            txtCelsiusToKelvin.Enabled = false;
            txtCelsiusToKelvin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelsiusToKelvin.Location = new Point(630, 163);
            txtCelsiusToKelvin.Name = "txtCelsiusToKelvin";
            txtCelsiusToKelvin.ReadOnly = true;
            txtCelsiusToKelvin.Size = new Size(110, 25);
            txtCelsiusToKelvin.TabIndex = 18;
            // 
            // txtKelvinToCelsius
            // 
            txtKelvinToCelsius.Enabled = false;
            txtKelvinToCelsius.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKelvinToCelsius.Location = new Point(500, 213);
            txtKelvinToCelsius.Name = "txtKelvinToCelsius";
            txtKelvinToCelsius.ReadOnly = true;
            txtKelvinToCelsius.Size = new Size(110, 25);
            txtKelvinToCelsius.TabIndex = 19;
            // 
            // txtKelvinToKelvin
            // 
            txtKelvinToKelvin.Enabled = false;
            txtKelvinToKelvin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKelvinToKelvin.Location = new Point(630, 213);
            txtKelvinToKelvin.Name = "txtKelvinToKelvin";
            txtKelvinToKelvin.ReadOnly = true;
            txtKelvinToKelvin.Size = new Size(110, 25);
            txtKelvinToKelvin.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 254);
            Controls.Add(txtKelvinToKelvin);
            Controls.Add(txtKelvinToCelsius);
            Controls.Add(txtCelsiusToKelvin);
            Controls.Add(txtCelsiusToCelsius);
            Controls.Add(txtKelvinToFahrenhait);
            Controls.Add(txtCelsiusToFahrenhait);
            Controls.Add(txtFahrenhaitToKelvin);
            Controls.Add(txtFahrenhaitToCelsius);
            Controls.Add(txtFahrenhaitToFahrenhait);
            Controls.Add(lblKelvin);
            Controls.Add(lblCelsius);
            Controls.Add(lblFahrenhait);
            Controls.Add(btnConversionKelvin);
            Controls.Add(btnConversionCelsius);
            Controls.Add(btnConversionFahrenheit);
            Controls.Add(txtKelvin);
            Controls.Add(txtCelsius);
            Controls.Add(txtFahrenheit);
            Controls.Add(lblKelvinA);
            Controls.Add(lblCelsiusA);
            Controls.Add(lblFahrenheitA);
            ForeColor = SystemColors.InfoText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblFahrenheitA;
        private TextBox lblCelsiusA;
        private TextBox lblKelvinA;
        private TextBox txtFahrenheit;
        private TextBox txtCelsius;
        private TextBox txtKelvin;
        private Button btnConversionFahrenheit;
        private Button btnConversionCelsius;
        private Button btnConversionKelvin;
        private TextBox lblFahrenhait;
        private TextBox lblCelsius;
        private TextBox lblKelvin;
        private TextBox txtFahrenhaitToFahrenhait;
        private TextBox txtFahrenhaitToCelsius;
        private TextBox txtFahrenhaitToKelvin;
        private TextBox txtCelsiusToFahrenhait;
        private TextBox txtKelvinToFahrenhait;
        private TextBox txtCelsiusToCelsius;
        private TextBox txtCelsiusToKelvin;
        private TextBox txtKelvinToCelsius;
        private TextBox txtKelvinToKelvin;
    }
}