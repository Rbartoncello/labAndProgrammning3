using System.Text;

namespace Entidades
{
    public class Alumno: Persona
    {
        private string _legajo;
        private Dictionary<EMateria, List<int>> _materiasAsignadas;

        private Alumno(int dni) : base(dni)
        {
            _materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        public Alumno(int dni, string legajo) : this(dni)
        {
            this._legajo = legajo;
        }

        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            return alumno._materiasAsignadas.Any(keyValuePair => keyValuePair.Key == materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if(alumno == materia)
                return false;

            alumno._materiasAsignadas.Add(materia, new List<int>());
            return true;
        }
        /// <summary>
        /// Va necesita que el pase un enum del tipo EMateria y va retornar false en el caso que no sea de la materia a rendir y true en caso contrario
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>

        public bool RendirExamen(EMateria materia)
        {
            if(this != materia)
                return false;

            int rnd = new Random().Next(1, 10);

            foreach (var keyValue in _materiasAsignadas)
            {
                for (int i = 0; i < keyValue.Value.Capacity; i++)
                {
                    keyValue.Value[i] = rnd;
                }
            }

            return true;
        }

        public static implicit operator Alumno(string dni)
        {
            Alumno alumno = new Alumno(dni.GetHashCode());
            alumno._legajo = alumno.GetHashCode().ToString();
            return alumno;
        }

        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine("Materias: ");

            foreach (var keyValuePair in _materiasAsignadas)
                sb.AppendLine($"-{keyValuePair.Key}");
            
            return sb.ToString();
        }

        public override string Informacion => $"Alumno - \n{MostrarDatos()}";

        public List<int> this[EMateria materia] => this != materia ? null : _materiasAsignadas[materia];

        public override string ToString()
        {
            return $"Alumno - {_legajo}";
        }
    }
}