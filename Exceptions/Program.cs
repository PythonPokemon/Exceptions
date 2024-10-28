using System;

namespace Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var result = Calc(10, 0);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Etwas geht schief!" + e);
            }
            finally
            {
                Console.WriteLine("wird immer ausgegeben");
            }
            
            Console.WriteLine("Hello, World!");
        }

        static int Calc(int a, int b)
        {
            return a / b;
        }
    }
}