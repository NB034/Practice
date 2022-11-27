using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal static class ExceptionsThrower
    {
        static public void Thrower()
        {
            try
            {
                int a = 4;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                List<int> obj = null;
                obj.Max();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int[] array = new[] { 1, 2, 3 };
                array[3] = 4;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                bool check = true;
                List<Exception> exceptions = (List<Exception>)(object)check;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nAll exceptions was catched!");
        }
    }
}
