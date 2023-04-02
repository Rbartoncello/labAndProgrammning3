namespace Exersice8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
               trabajadas en el mes de N empleados de una fábrica.
               
               Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
               valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
               multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
               descuentos.
               Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
               bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
               Nota: Utilizar estructuras repetitivas y selectivas.
             */

            const int valueAntiquity = 150;
            const double percentageDiscount = 0.13;
            int hourValue = 0;
            string nameEmployer = "";
            int antiquity = 0;
            int monthHours = 0;
            double salaryTotal = 0;
            double discount = 0;
            double salaryWithDiscount = 0;
            bool newEmployer = true;

            while (newEmployer)
            {
                Console.WriteLine("Ingrese el valor de la hora de trabajo");
                hourValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el del empleado");
                nameEmployer = Console.ReadLine();
                Console.WriteLine("Ingrese ingrese la antiguedad (en años) de: {0}", nameEmployer);
                antiquity = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de horas trabajadas en el mes de {0}", nameEmployer);
                monthHours = int.Parse(Console.ReadLine());

                salaryTotal = hourValue * monthHours + antiquity * valueAntiquity;
                discount = salaryTotal * percentageDiscount;
                salaryWithDiscount = salaryTotal - discount;

                Console.WriteLine("Empleado: {0} ------ Antiguedad: {1} ----- Valor hora: {2} ------ Sueldo bruto: {3} ------ Descuentos: {4} ----- Sueldo neto: {5}", nameEmployer, antiquity, hourValue, salaryTotal, discount, salaryWithDiscount);

                Console.WriteLine("Quiere ingresar un nuevo empleado");
                string answer = Console.ReadLine();
                newEmployer = answer == "si";
            }

            

        }
    }
}