namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombutible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public AutoF1(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public string MostrarDatos()
        {
            return $"Escuderia: {this.escuderia} \n" +
                   $"Numero: {this.numero} \n" + $"Vueltas restantes: {this.vueltasRestantes} \n";
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
        }

        public short Combustible
        {
            get
            {
                return this.cantidadCombutible;
            }
            set
            {
                this.cantidadCombutible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public void montarEnPista(short cantidadVueltas)
        {
            this.vueltasRestantes = cantidadVueltas;
            this.enCompetencia = true;
            this.cantidadCombutible = (short)new Random().Next(15, 100);
        }
    }
}