using System.Drawing;
using Temperature;
namespace Exercise_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Celsius c;
        private Fahrenheit f;
        private Kelvin k;

        private void txtTemperature_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnConversionFahrenheit_Click(object sender, EventArgs e)
        {
            if (this.txtFahrenheit.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la temperatura en Fahrenheit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double temp = 0;
                double.TryParse(this.txtFahrenheit.Text, out temp);
                this.f = temp;
                this.txtFahrenhaitToFahrenhait.Text = $"{this.f.getTemperature()}";
                this.txtFahrenhaitToCelsius.Text = $"{((Celsius)this.f).getTemperature()}";
                this.txtFahrenhaitToKelvin.Text = $"{((Kelvin)this.f).getTemperature()}";
            }
        }

        private void btnConversionCelsius_Click(object sender, EventArgs e)
        {
            if (this.txtCelsius.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la temperatura en Celsius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double temp = 0;
                double.TryParse(this.txtCelsius.Text, out temp);
                this.c = temp;
                this.txtCelsiusToFahrenhait.Text = $"{((Fahrenheit)this.c).getTemperature()}";
                this.txtCelsiusToCelsius.Text = $"{(this.c).getTemperature()}";
                this.txtCelsiusToKelvin.Text = $"{((Kelvin)this.c).getTemperature()}";
            }
        }

        private void btnConversionKelvin_Click(object sender, EventArgs e)
        {
            if (this.txtKelvin.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la temperatura en Kelvin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double temp = 0;
                double.TryParse(this.txtKelvin.Text, out temp);
                this.k = temp;
                this.txtKelvinToFahrenhait.Text = $"{((Fahrenheit)this.k).getTemperature()}";
                this.txtKelvinToCelsius.Text = $"{((Celsius)this.k).getTemperature()}";
                this.txtKelvinToKelvin.Text = $"{(this.k).getTemperature()}";
            }
        }
    }
}