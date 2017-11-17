using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersionsDemos
{
    public static class Tuples
    {
        public static (bool result, double cal) CalculationTuple()
        {
            return (true, new Random().NextDouble());
        }
            
    }
}
