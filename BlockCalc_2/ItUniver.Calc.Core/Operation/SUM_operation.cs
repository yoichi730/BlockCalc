﻿using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operation
{
    class SUM : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "SUM";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x + y);
        }
    }
}
