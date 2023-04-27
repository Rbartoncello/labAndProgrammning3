namespace Libro
{
    public class Libro1
    {
        private List<string> _paginas;

        public Libro1()
        {
            _paginas = new List<string>();
        }


        public string this[int index]
        {
            get
            {
                if (index <= 0 || index >= _paginas.Count)
                    return "";
                return _paginas[index];
            }
            set
            {
                if (_paginas is null || index >= _paginas.Count())
                    _paginas.Add(value);
                else
                    _paginas[index] = value;
            }
        }
    }
}