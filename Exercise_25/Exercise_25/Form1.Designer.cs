namespace Exercise_25
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
            lblBinToDec = new TextBox();
            lblDecToBin = new TextBox();
            inputBinToDec = new TextBox();
            inputDecToBin = new TextBox();
            txtDecToBin = new TextBox();
            txtBinToDec = new TextBox();
            btnBinToDec = new Button();
            btnDecToBin = new Button();
            SuspendLayout();
            // 
            // lblBinToDec
            // 
            lblBinToDec.BackColor = SystemColors.ActiveCaption;
            lblBinToDec.BorderStyle = BorderStyle.None;
            lblBinToDec.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBinToDec.Location = new Point(12, 102);
            lblBinToDec.Name = "lblBinToDec";
            lblBinToDec.ReadOnly = true;
            lblBinToDec.Size = new Size(150, 22);
            lblBinToDec.TabIndex = 0;
            lblBinToDec.Text = "Binario a decimal";
            // 
            // lblDecToBin
            // 
            lblDecToBin.BackColor = SystemColors.ActiveCaption;
            lblDecToBin.BorderStyle = BorderStyle.None;
            lblDecToBin.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDecToBin.Location = new Point(12, 145);
            lblDecToBin.Name = "lblDecToBin";
            lblDecToBin.ReadOnly = true;
            lblDecToBin.Size = new Size(150, 22);
            lblDecToBin.TabIndex = 1;
            lblDecToBin.Text = "Decimal a binario";
            // 
            // inputBinToDec
            // 
            inputBinToDec.Location = new Point(180, 102);
            inputBinToDec.Name = "inputBinToDec";
            inputBinToDec.Size = new Size(100, 23);
            inputBinToDec.TabIndex = 2;
            inputBinToDec.KeyPress += inputBinToDec_KeyPress;
            // 
            // inputDecToBin
            // 
            inputDecToBin.Location = new Point(180, 145);
            inputDecToBin.Name = "inputDecToBin";
            inputDecToBin.Size = new Size(100, 23);
            inputDecToBin.TabIndex = 3;
            inputDecToBin.KeyPress += inputDecToBin_KeyPress;
            // 
            // txtDecToBin
            // 
            txtDecToBin.Enabled = false;
            txtDecToBin.Location = new Point(370, 144);
            txtDecToBin.Name = "txtDecToBin";
            txtDecToBin.ReadOnly = true;
            txtDecToBin.Size = new Size(100, 23);
            txtDecToBin.TabIndex = 5;
            // 
            // txtBinToDec
            // 
            txtBinToDec.Enabled = false;
            txtBinToDec.Location = new Point(370, 102);
            txtBinToDec.Name = "txtBinToDec";
            txtBinToDec.ReadOnly = true;
            txtBinToDec.Size = new Size(100, 23);
            txtBinToDec.TabIndex = 6;
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(309, 102);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(30, 30);
            btnBinToDec.TabIndex = 7;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(309, 137);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(30, 30);
            btnDecToBin.TabIndex = 8;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(503, 182);
            Controls.Add(btnDecToBin);
            Controls.Add(btnBinToDec);
            Controls.Add(txtBinToDec);
            Controls.Add(txtDecToBin);
            Controls.Add(inputDecToBin);
            Controls.Add(inputBinToDec);
            Controls.Add(lblDecToBin);
            Controls.Add(lblBinToDec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblBinToDec;
        private TextBox lblDecToBin;
        private TextBox inputBinToDec;
        private TextBox inputDecToBin;
        private TextBox txtDecToBin;
        private TextBox txtBinToDec;
        private Button btnBinToDec;
        private Button btnDecToBin;
    }
}