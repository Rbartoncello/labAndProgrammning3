using Entidades;
namespace Exercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[3];

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del Alumno");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del Alumno");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Ingrese el legajo de {lastName}, {name}");
                int idUniversity = int.Parse(Console.ReadLine());

                alumnos[i] = new Alumno(lastName, name, idUniversity);

                Console.WriteLine($"Ingrese el primera nota del Alumno:  {lastName}, {name}");
                byte gradeOne = byte.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el segunda nota del Alumno:  {lastName}, {name}");
                byte gradeTwo = byte.Parse(Console.ReadLine());

                alumnos[i].Estudiar(gradeOne, gradeTwo);

                Console.Clear();
            }


            foreach (Alumno alumno in alumnos)
            {
                alumno.CalcularFinal();
                Console.WriteLine(alumno.Mostra());
            }
                
        }
    }
}