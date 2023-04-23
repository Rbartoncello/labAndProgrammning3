namespace Exercise_27
{
    internal class Program
    {
        static void PrintList(List<int> data)
        {
            foreach (int i in data)
            {
                Console.Write($" {i} ");
            }
        }
        static void PrintQueve(Array data)
        {
            foreach (int i in data)
            {
                Console.Write($" {i} ");
            }
        }
        static void PrintStack(List<int> data)
        {
            foreach (int i in data)
            {
                Console.Write($" {i} ");
            }
        }
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();
            Queue<int> numbersQueue = new Queue<int>();
            Stack<int> numbersStack= new Stack<int>();

            Random rnd = new Random();
            int numbRdm = rnd.Next(-100, 100);

            for (int i = 0; i < 20; i++)
            {
                if (numbRdm != 0)
                    numbersList.Add(numbRdm);
                numbRdm = rnd.Next(-100, 100);

                if (numbRdm != 0)
                    numbersQueue.Enqueue(numbRdm);
                numbRdm = rnd.Next(-100, 100); 

                if (numbRdm != 0)
                    numbersStack.Push(numbRdm);
                numbRdm = rnd.Next(-100, 100);
            }

            List<int> numbersPositiveList = new List<int>();
            List<int> numbersNegativeList = new List<int>();
            Queue<int> numbersPositiveQueue= new Queue<int>();
            Queue<int> numbersNegativeQueue= new Queue<int>();
            Stack<int> numbersPositiveStack = new Stack<int>();
            Stack<int> numbersNegativeStack = new Stack<int>();


            foreach (int number in numbersList)
            {
                Console.Write($" {number} ");
                if(number > 0)
                    numbersPositiveList.Add(number);
                else
                    numbersNegativeList.Add(number);
            }
            Console.WriteLine("\nQueue: --------------");

            foreach (int number in numbersQueue)
            {
                Console.Write($" {number} ");
                if (number > 0)
                    numbersPositiveQueue.Enqueue(number);
                else
                    numbersNegativeQueue.Enqueue(number);
            }
            Console.WriteLine("\nStack: --------------");

            foreach (int number in numbersStack)
            {
                Console.Write($" {number} ");
                if (number > 0)
                    numbersPositiveStack.Push(number);
                else
                    numbersNegativeStack.Push(number);
            }
            numbersNegativeList.Sort();
            numbersPositiveList.Sort();
            numbersPositiveList.Reverse();

            int[] numbersNegativeQueueArray = numbersNegativeQueue.ToArray();
            int[] numbersPositiveQueueArray = numbersPositiveQueue.ToArray();
            Array.Sort(numbersNegativeQueueArray);
            Array.Sort(numbersPositiveQueueArray);
            Array.Reverse(numbersPositiveQueueArray);

            int[] numbersNegativeStackArray = numbersNegativeStack.ToArray();
            int[] numbersPositiveStackArray = numbersPositiveStack.ToArray();
            Array.Sort(numbersNegativeStackArray);
            Array.Sort(numbersPositiveStackArray);
            Array.Reverse(numbersPositiveStackArray);

            Console.WriteLine("\nPositive list--------------");

            PrintList(numbersPositiveList);
            Console.WriteLine("\nNegative list--------------");

            PrintList(numbersNegativeList);

            Console.WriteLine("\nPositive Queue--------------");
            PrintQueve(numbersPositiveQueueArray);
            Console.WriteLine("\nNegative Queue--------------");
            PrintQueve(numbersNegativeQueueArray);

            Console.WriteLine("\nPositive Stack--------------");
            PrintQueve(numbersPositiveStackArray);
            Console.WriteLine("\nNegative Stack--------------");
            PrintQueve(numbersNegativeStackArray);


        }
    }
}