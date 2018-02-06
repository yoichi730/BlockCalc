using ITUniver.Calc.Core.Operation;
using System;

namespace BlockCalc_2
{
    public class My_Expression
    {
        public static int argCount = 0;

        private static string[] operations = {"SUM","SUB","DIV","MUL"};      

        public double SUM (int argCount, double[] arguments)
        {
            var oper = new SUM();
            var result = oper.Exec(arguments);
            return result;
        }

        public double SUB (int argCount, double[] arguments)
        {
            var oper = new SUB();
            var result = oper.Exec(arguments);
            return result;
        }

        public double MUL (int argCount, double[] arguments)
        {
            var oper = new MUL();
            var result = oper.Exec(arguments);
            return result;
        }

        public double DIV (int argCount, double[] arguments)
        {
            var oper = new DIV();
            var result = oper.Exec(arguments);
            return result;
        }

        public string getAnswer(string inputStream)
        {            
            String[] inputExpression = inputStream.Split(',', ' ');
            for (int i = 0; i < inputExpression.Length; i++)
            {
                if (inputExpression[0] == operations[i])
                {
                    My_Expression exp = new My_Expression();
                    // создаем массив сторк для хранения аргументов
                    double[] args = new double[inputExpression.Length - 1];
                    //конвертируем его в double[] и начинаем формировать ответ
                    string answer = $"{inputExpression[0]}(";
                    for (int j = 0; j < args.Length; j++)
                    {
                        args[j] = Convert.ToDouble(inputExpression[j + 1]);
                        answer += inputExpression[j + 1] + ',';
                    }
                    
                    if (inputExpression[0] == "SUM") return answer += $") = {exp.SUM(args.Length, args)}";
                    if (inputExpression[0] == "SUB") return answer += $") = {exp.SUB(args.Length, args)}";
                    if (inputExpression[0] == "DIV") return answer += $") = {exp.DIV(args.Length, args)}";
                    if (inputExpression[0] == "MUL") return answer += $") = {exp.MUL(args.Length, args)}";
                }
            }
            return "Неизвестный оператор";

        }

    }
}
