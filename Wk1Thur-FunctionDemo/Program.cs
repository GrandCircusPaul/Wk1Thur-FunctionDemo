using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Thur_FunctionDemo
{
    class Program
    {
        // enum is declared in the class, outside of the functions (including main function)
        // past == 0  and future = 1
        enum timeDirection {past, future};

        // The "Main" function, only one per program; only one active per project.
        static void Main(string[] args)
        {
            int myInt = simpleFn(args);
            Console.WriteLine(myInt);
            
            Console.WriteLine(currentTime());
            Console.WriteLine(pastTime());
            Console.WriteLine(futureTime());
            Console.WriteLine(timeDifference(futureTime(), currentTime()));
            Console.WriteLine(yearsDifference(futureTime(), currentTime()));
            Console.WriteLine(2916270 / 365);
            Console.WriteLine(daysDifference(futureTime(), currentTime()));



            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            // Using Enum to set switch statement value

            Console.WriteLine(Factorial(4));
            
            int switchValue = -1;

            switchValue = (int) timeDirection.future;

            switch(switchValue)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    Console.WriteLine("Past Time");
                    Console.WriteLine(pastTime());

                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    Console.WriteLine("Future Time");
                    Console.WriteLine(futureTime());

                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
        public static int simpleFn (string [] stringArray)
        {
            return stringArray.Length;
        }
        public static DateTime currentTime ()
        {
            return DateTime.Now;
        }
        public static DateTime pastTime()
        {
            return DateTime.MinValue;
        }
        public static DateTime futureTime()
        {
            return DateTime.MaxValue;
        }
        public static TimeSpan timeDifference(DateTime time1, DateTime time2)
        {
            return time1 - time2;
        }
        public static int yearsDifference(DateTime time1, DateTime time2)
        {
            return time1.Year - time2.Year;
        }

        // A user defined function that calls another user defined function!
        public static int daysDifference(DateTime time1, DateTime time2)
        {
            return timeDifference(time1, time2).Days;
        }

        // A recursive function
        public static int Factorial(int number)
        {
            // The halting condition - necessary for all recursive functions!
            if (number <= 0)
            {
                return 1;
            }
            else
            {
                int temp = Factorial(number - 1); // The recursive call // temp is created to help trace recursion with debugger
                temp *= number;
                return temp;
            }
        }
    }
}
