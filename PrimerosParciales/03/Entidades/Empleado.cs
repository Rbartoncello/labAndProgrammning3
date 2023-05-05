namespace Entidades
{
    public abstract class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;


        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        protected TimeSpan HoraIngreso => horaIngreso;

        protected string Legajo => legajo;

        protected string Nombre => nombre;

        public TimeSpan HoraEgreso
        {
            get => horaEgreso;
            set => horaEgreso = ValidaHoraEgreso(value);
        }

        private TimeSpan ValidaHoraEgreso(TimeSpan horaEgreso)
        {
            return horaEgreso > HoraIngreso ? horaEgreso : DateTime.Now.TimeOfDay;
        }

        protected double Facturar()
        {
            return horaEgreso.Subtract(horaIngreso).TotalHours;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            return emp1.Legajo == emp2.Legajo;
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

        public abstract string EmitirFactura();
    }
}