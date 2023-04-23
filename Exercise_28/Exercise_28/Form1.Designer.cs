namespace Exercise_28
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
            txtBox = new RichTextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 12);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(405, 371);
            txtBox.TabIndex = 0;
            txtBox.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCalculate.FlatAppearance.BorderSize = 2;
            btnCalculate.FlatAppearance.MouseDownBackColor = Color.Olive;
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculate.Location = new Point(12, 395);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(405, 42);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtBox;
        private Button btnCalculate;
    }
}