using System;

namespace Generic_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics programs");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.FindMaxInt");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the first value");
                    int First_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second value");
                    int Second_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Three value");
                    int Third_val = Convert.ToInt32(Console.ReadLine());
                    FindMaxInt.FindIntMaxVal(First_val, Second_val, Third_val);
                    break;
            }
            Console.ReadLine();
        }
    }
}