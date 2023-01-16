using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Programs
{
    class GenericRefactor1<T> where T : IComparable
    {
        public static T FindMax(T First_value, T Second_value, T Third_value)
        {
            if (First_value.CompareTo(Second_value) > 0 && First_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("Greater is :" + First_value);
                return First_value;
            }
            else if (Second_value.CompareTo(First_value) > 0 && Second_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("Greater is:" + Second_value);
                return Second_value;
            }
            else
            {
                Console.WriteLine("Greater is: " + Third_value);
                return Third_value;
            }
        }
    }
}