namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerzas;

        public AutoF1(string escuderia, short numero) : base(escuderia, numero, Competencia.ETipoCompetencia.F1){ }

        public AutoF1(string escuderia, short numero, short caballosDeFuerzas) : this(escuderia, numero)
        {
            this.caballosDeFuerzas = caballosDeFuerzas;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerzas == a2.CaballosDeFuerzas);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short CaballosDeFuerzas
        {
            get => caballosDeFuerzas;
            set => caballosDeFuerzas = value;
        }
    }
}