using ITUniver.Calc.Core.Interfaces;
using System;

namespace ITUniver.Calc.WebCalc.Models
{
    public class _Operations : IOperation
    {       

        public int argCount { get; }
        
        public string Name { get; }
        
        public double Exec(double[] args)
        {
            throw new NotImplementedException();
        }
    }
}