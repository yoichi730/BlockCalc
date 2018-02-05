using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCalc_2
{
    class Program
    {
        static void Main(string[] args)
        {

            _Expression expr = new _Expression();
            if (args.Length == 0)
            {
                Console.WriteLine("Калькулятор");
                Console.Write("Введите выражение (SUM/SUB/DIV/MUL): ");
                string _oper = Console.ReadLine();

                Console.Write("Введите первую переменную: ");
                double X = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите вторую переменную: ");
                double Y = Convert.ToDouble(Console.ReadLine());

                expr.getAnswer(_oper, X, Y); 
            }
            else
            {
                expr.getAnswer(args[0], Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
            }


        }




    }
}
