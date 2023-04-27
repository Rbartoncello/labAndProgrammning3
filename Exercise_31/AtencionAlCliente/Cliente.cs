namespace AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(string nombre, int numero): this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Numero
        {
            get => numero;
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.Numero == b.Numero;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}