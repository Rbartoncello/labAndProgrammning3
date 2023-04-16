using Conversion;
namespace Exercise_25
{
    public partial class Form1 : Form
    {
        private NumeroBinario bin;
        private NumeroDecimal dec;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (this.inputBinToDec.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar el numero binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.txtBinToDec.Text = $"{(Conversion.Conversion.BinarioDecimal(this.inputBinToDec.Text))}";

        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (this.inputDecToBin.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar el numero decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int num = 0;
                int.TryParse(this.inputDecToBin.Text, out num);
                this.txtDecToBin.Text = $"{(Conversion.Conversion.DecimalBinario(num))}";
            }
        }

        private void inputBinToDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void inputDecToBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }
    }
}