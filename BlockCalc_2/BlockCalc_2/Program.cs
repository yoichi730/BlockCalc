using System;

namespace BlockCalc_2
{
    class Program
    {
        static void Main(string[] args)
        {

            My_Expression expr = new My_Expression();
            
            if (args.Length == 0)
            {
                Console.WriteLine("Калькулятор");
                Console.Write("Введите выражение[OPERATOR X1,X2,..,Xn]: ");
                string inputStream = Console.ReadLine();
                
                Console.ReadKey();
            }
            else
            {
                string inputStream = Convert.ToString(args[0]) + ' ' + Convert.ToString(args[1]);
                Console.ReadKey();
            }
               
        }
    }
}
