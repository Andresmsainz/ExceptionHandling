using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling!");

            int x = 0;
            int y = 3;
            double div = 0;

            try
            {
                div = y / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Result is : " + div);
            }
            

            
        }
    }
}
