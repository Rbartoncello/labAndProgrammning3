using Billetes;

namespace Exercise_23
{
    public partial class Form1 : Form
    {
        private Euro e;
        private Dolar d;
        private Peso p;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtCotizacionEuro.Text, out numero);
            Euro.SetCotizacion(numero);
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtCotizacionPeso.Text, out numero);
            Peso.SetCotizacion(numero);
            double numeor = Peso.getCotizacion();

        }


        private void txtCotizacionEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtEuro.Text, out numero);
            this.e = numero;
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtDolar.Text, out numero);
            this.d = numero;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtPeso.Text, out numero);
            this.p = numero;
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(0))
                MessageBox.Show("Error! Primero debe blockear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtEuro.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la cantidad de Euros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtEuroAEuro.Text = $"{this.e.getCantidad()}";
                this.txtEuroADolar.Text = $"{((Dolar)this.e).getCantidad()}";
                this.txtEuroAPeso.Text = $"{((Peso)this.e).getCantidad()}";
            }

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(0))
                MessageBox.Show("Error! Primero debe blockear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(this.txtDolar.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la cantidad de Dolares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtDolarAEuro.Text = $"{((Euro)this.d).getCantidad()}";
                this.txtDolarADolar.Text = $"{this.d.getCantidad()}";
                this.txtDolarAPeso.Text = $"{((Peso)this.d).getCantidad()}";
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(0))
                MessageBox.Show("Error! Primero debe blockear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtPeso.Text.Equals(""))
                MessageBox.Show("Error! Primero debe agragar la cantidad de Peso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtPesoAEuro.Text = $"{((Euro)this.p).getCantidad()}";
                this.txtPesoADolar.Text = $"{((Dolar)this.p).getCantidad()}";
                this.txtPesoAPeso.Text = $"{this.p.getCantidad()}";
            }
        }

        private bool isSomePriceEmply()
        {
            return this.txtCotizacionEuro.Text.Equals("") || this.txtCotizacionPeso.Text.Equals("");
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(0))
            {
                if (isSomePriceEmply())
                    MessageBox.Show("Error! primero debe agragar todas la cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.btnLockCotizacion.ImageIndex = 1;
                    this.txtCotizacionEuro.ReadOnly = true;
                    this.txtCotizacionPeso.ReadOnly = true;
                    this.txtCotizacionEuro.Enabled = false;
                    this.txtCotizacionPeso.Enabled = false;
                }
            }
            else
            {
                this.txtCotizacionEuro.ReadOnly = false;
                this.txtCotizacionPeso.ReadOnly = false;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
                this.btnLockCotizacion.ImageIndex = 0;
            }
        }
    }
}