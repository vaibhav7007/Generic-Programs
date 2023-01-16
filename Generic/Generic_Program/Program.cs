using System;

namespace Generic_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics programs");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.FindMaxInt\n2.FindFloat\n3.FindMaxString\n4.Refactor1\n5.Refactor2");
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

                case 2:
                    FindFloatMax.FindFloatMaxVal(12.3f, 44.5f, 55.6f);
                    break;
                case 3:
                    FindMaxString.FindString("Apple", "Banana", "Guava");
                    break;
                case 4:
                    GenericRefactor1<int>.FindMax(100, 200, 500);
                    GenericRefactor1<float>.FindMax(10.5f, 20.7f, 56.8f);
                    GenericRefactor1<string>.FindMax("Apple", "Bannana", "Guava");
                    break;
                case 5:
                    GenericsRefactor2<int> genericRefactor2 = new GenericsRefactor2<int>(12, 40, 60);
                    genericRefactor2.TestMaximum();
                    break;
            }

            Console.ReadLine();
        }
    }
}