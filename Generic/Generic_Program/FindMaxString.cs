using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Programs
{
    class FindMaxString
    {
        public static string FindString(string First_value, string Second_value, string Third_value)
        {
            if (First_value.CompareTo(Second_value) > 0 && First_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("First string is Greater :" + First_value);
                return First_value;
            }
            else if (Second_value.CompareTo(First_value) > 0 && Second_value.CompareTo(Third_value) > 0)
            {
                Console.WriteLine("Second string is Greater :" + Second_value);
                return Second_value;
            }
            else
            {
                Console.WriteLine("Third string is Greater : " + Third_value);
                return Third_value;
            }
        }
    }
}