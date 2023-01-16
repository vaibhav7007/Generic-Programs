using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Programs
{
    class FindMaxInt
    {
        public static int FindIntMaxVal(int First_val, int Second_val, int Third_val)
        {
            if (First_val.CompareTo(Second_val) > 0 && First_val.CompareTo(Third_val) > 0)
            {
                Console.WriteLine("First value is Greater :" + First_val);
                return First_val;
            }
            else if (Second_val.CompareTo(First_val) > 0 && Second_val.CompareTo(Third_val) > 0)
            {
                Console.WriteLine("Second value is Greater :" + Second_val);
                return Second_val;
            }
            else
            {
                Console.WriteLine("Third value is Greater : " + Third_val);
                return Third_val;
            }
        }
    }
}