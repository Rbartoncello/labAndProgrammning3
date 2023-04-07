namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if (this.nota1 > 4 && this.nota2 > 4)
            {
                Random rd = new Random();
                this.notaFinal = rd.Next((int)this.nota1, (int)this.nota2);
            }
            else
                this.notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostra()
        {
            string retorno = $"Alumno: {this.apellido}, {this.nombre} con legajo: {this.legajo} ";
            if (this.notaFinal == -1)
                retorno += "Alumno desaprobado";
            else
                retorno += $"Nota: {this.notaFinal}";

            return retorno;
        }
    }
}