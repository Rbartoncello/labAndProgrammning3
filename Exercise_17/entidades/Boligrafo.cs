namespace entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta > 0)
                SumarTinta(tinta);
            else if (tinta < 0)
                RestarTinta(tinta);
        }

        private void RestarTinta(short tinta)
        {
            if (this.tinta + tinta < 0)
                this.tinta = 0;
            else
                this.tinta += tinta;
        }

        private void SumarTinta(short tinta)
        {
            if (this.tinta + tinta > Boligrafo.cantidadTintaMaxima) 
                this.tinta = Boligrafo.cantidadTintaMaxima;
            else 
                this.tinta += tinta;
        }

        public void Recargar()
        {
            SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            string aux = string.Empty;
            if (this.tinta == 0)
            {
                dibujo = "No se puedo pintar";
            }
            else
            {
                while (gasto > 0 && this.tinta > 0)
                {
                    aux += '*';
                    gasto--;
                    this.SetTinta(-1);
                }
                dibujo = aux;
                retorno = true;
            }


            return retorno;
        }
    }
}
