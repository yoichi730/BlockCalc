using ITUniver.Calc.Core.Interfaces;
using ITUniver.Calc.Core.Operation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BlockCalc_2
{ 
    
    public class My_Expression
    {
        private IList<IOperation> operations { get; set; }

        public My_Expression()
        {
            operations = new List<IOperation>();

            // Загружаем наши операции
            LoadOperation(Assembly.GetExecutingAssembly());

            // Загружаем сторонние библиотеки с операциями
            var extensionsDir = Path.Combine(Environment.CurrentDirectory, "Extensions");

            if (!Directory.Exists(extensionsDir))
                return;

            var files = Directory.GetFiles(extensionsDir, "*.dll");

            foreach (var file in files)
            {
                LoadOperation(Assembly.LoadFile(file));
            }

        }

        
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

        public double Exec(string oper, double[] args)
        {
            // найти операцию в списке
            var operation = operations
                .FirstOrDefault(o => o.Name == oper);

            // если не найдено - возвращает ошибку
            if (operation == null)
                return double.NaN;

            // если нашли
            // передаем ей аргументы и вычисляем результат
            var result = operation.Exec(args);

            // возвращаем результат
            return result;
        }

        public string[] GetOperNames()
        {
            //string[] res = {"SUM","SUB"};
            //return res;
            return operations.Select(it => it.Name).ToArray();
        }

        public string ArgumentsToString(double[] args, char ch)

        {
            string res = "";

            for (int i = 0; i < args.Length; i++)
            {
                res += $"{args[i]}";
                if (i != args.Length-1)
                {
                    res += $"{ch}";
                }
            }

            return res;
        }

        public string print(string oper, double[] args)
        {
            string Answer = $"{oper} ";

            My_Expression expr = new My_Expression();
            
            Answer += $"({expr.ArgumentsToString(args,',')}) = {expr.Exec(oper,args)}";

            return Answer;
        }

        private void LoadOperation(Assembly assembly)
        {
            var types = assembly.GetTypes();
            var typeOperation = typeof(IOperation);

            foreach (var item in types.Where(t => !t.IsAbstract && !t.IsInterface))
            {
                var interfaces = item.GetInterfaces();

                var isOperation = interfaces.Any(it => it == typeOperation);

                if (isOperation)
                {
                    // создаем эксземпляр объекта
                    var obj = Activator.CreateInstance(item);
                    // пытаемся превратить его в операцию
                    var operation = obj as IOperation;
                    // если удалось
                    if (operation != null)
                    {
                        // добавляем в список операций
                        operations.Add(operation);
                    }
                }
            }
        }

    }
}
