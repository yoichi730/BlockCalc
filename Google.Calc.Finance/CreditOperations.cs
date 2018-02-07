using ITUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Calc.Finance
{
    public class CreditOperations : ITUniver.Calc.Core.Interfaces.IOperation
    {
            public int argCount
            {
                get { return 2; }
            }

            public string Name => "CREDIT";

            public double Exec(double[] args)
            {
                return args.Aggregate((x, y) => x * 1.094);
            }
     }
}
