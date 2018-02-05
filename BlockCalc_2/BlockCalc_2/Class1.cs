using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCalc_2
{
    public class _Expression
    {
        public double x = 0;
        public double y = 0;
        private string[] oper_words = { "SUM", "SUB", "MUL", "DIV" };
        private string oper = "SUM";
        private int errCode = 0;
        private string[] errMessage =
            {
            "нет ошибки",
            "деление на \'0\'",
            "неизвестный оператор"
            };
        public double SUM()
        {
            return this.x + this.y;
        }

        public double SUB()
        {
            return this.x - this.y;
        }

        public double MUL()
        {
            return this.x * this.y;
        }

        public double DIV()
        {
            if (this.y == 0)
            {
                this.errCode = 1;
                return 0;
            }
            else return this.x / this.y;
        }

        public int getErrCode()
        {
            return this.errCode;
        }

        public string getErrMessage()
        {
            return this.errMessage[this.errCode];
        }

        public void getAnswer(string input_oper, double input_x, double input_y)
        {
            this.oper = input_oper;
            this.x = input_x;
            this.y = input_y;

            for (int i = 0; i < this.oper_words.LongLength; i++)
            {
                if (this.oper != this.oper_words[i])
                {
                    this.errCode = 2;
                }
                else
                {
                    this.errCode = 0;
                    break;
                }
            }
            this.DIV();
            if (this.errCode == 0)
            {
                if (this.oper == "SUM") Console.WriteLine($"  SUM({this.x},{this.y}) = {SUM()}");
                else if (this.oper == "SUB") Console.WriteLine($"  SUB({this.x},{this.y}) = {SUB()}");
                else if (this.oper == "DIV") Console.WriteLine($"  DIV({this.x},{this.y}) = {DIV()}");
                else if (this.oper == "MUL") Console.WriteLine($"  MUL({this.x},{this.y}) = {MUL()}");
                //Console.WriteLine(this.getErrMessage());
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(this.getErrMessage());
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            }


        }



    }
}
