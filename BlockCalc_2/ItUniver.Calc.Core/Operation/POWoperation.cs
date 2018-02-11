using ITUniver.Calc.Core.Interfaces;
using System;
using System.Linq;

namespace ITUniver.Calc.Core.Operation
{
    public class POW_Operation : IOperation
        {
            public int argCount
            {
                get { return 2; }
            }

            public string Name => "POW";

            public double Exec(double[] args)
            {
                return args.Aggregate((x, y) => Math.Pow(x, y));
            }
        }
}
