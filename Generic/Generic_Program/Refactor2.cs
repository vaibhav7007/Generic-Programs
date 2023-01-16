using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Programs
{
    class GenericsRefactor2<T> where T : IComparable
    {
        public T First_value, Second_value, Third_value;
        public GenericsRefactor2(T First_value, T Second_value, T Third_value)
        {
            this.First_value = First_value;
            this.Second_value = Second_value;
            this.Third_value = Third_value;
        }

        public static T FindMax(T First_value, T Second_value, T Third_value)
        {
            if (First_value.CompareTo(Second_value) > 0 && First_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("Greater value is :" + First_value);
                return First_value;
            }
            else if (Second_value.CompareTo(First_value) > 0 && Second_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("Greater value is:" + Second_value);
                return Second_value;
            }
            else
            {
                Console.WriteLine("Greater value is: " + Third_value);
                return Third_value;
            }
        }

        public void TestMaximum()
        {
            T res = FindMax(First_value, Second_value, Third_value);
            Console.WriteLine("Max value is " + res);
        }
    }
}