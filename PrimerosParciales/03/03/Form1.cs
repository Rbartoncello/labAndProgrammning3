using Entidades;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cmbGrupo.DataSource = Enum.GetValues(typeof(Rac.EGrupo));
            this.cmbTipo.DataSource = new List<string> { "Supervisor", "Rac" };
            this.centro = new CentroDeAtencion("Teleperformance", 3);
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipo.SelectedItem is not null)
            {


                if (this.cmbTipo.SelectedItem.ToString() == "Rac")
                {
                    this.lblGrupo.Visible = true;
                    this.cmbGrupo.Visible = true;
                }
                else
                {
                    this.lblGrupo.Visible = false;
                    this.cmbGrupo.Visible = false;
                }
            }

        }

        private void ActualizaLista()
        {
            this.lstEmpleados.DataSource = null;
            this.lstEmpleados.DataSource = centro.Empleados;

        }

        private void btnIngresoEmp_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            string mensaje = string.Empty;
            if (this.cmbTipo.SelectedItem.ToString() == "Rac")
            {
                empleado = new Rac(this.txtLegajo.Text, txtNombre.Text, this.dtpHoraIngreso.Value.TimeOfDay, (Rac.EGrupo)this.cmbGrupo.SelectedItem);
            }
            else
            {
                empleado = new Supervisor(this.txtLegajo.Text, txtNombre.Text, this.dtpHoraIngreso.Value.TimeOfDay);
            }

            if (centro + empleado)
            {
                mensaje = "Se agrego nuevo empleado";
            }
            else
            {
                mensaje = "No se puedo agregar el empleado";
            }
            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ActualizaLista();

        }

        private void btnEgresoEmp_Click(object sender, EventArgs e)
        {
            Empleado? empSeleccionado = this.lstEmpleados.SelectedItem as Empleado;
            if (empSeleccionado is not null)
            {
                MessageBox.Show(this.centro - empSeleccionado, "Informacion Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.ActualizaLista();

        }
    }
}