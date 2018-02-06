using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operation
{
    class SUB : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "SUB";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x - y);
        }
    }
}

