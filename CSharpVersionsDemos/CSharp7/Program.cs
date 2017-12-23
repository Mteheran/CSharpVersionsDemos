using System;
using System.Configuration;
using System.Threading.Tasks;

namespace CSharpVersionsDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------- Out Parameters Demo-----------------");
            OutParameters.DemoOutParameters(out string tittle, out string message);
            Console.WriteLine("{0} - {1}", tittle, message);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Local Functions -----------------");

            string HelloWorld()
            {
                return "Hello World from a local function";
            }

            Console.WriteLine(HelloWorld());

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Pattern Matching -----------------");
            var randomtype = PatternMatching.GetPattern();

            switch (randomtype)
            {
                case Hello1 h1:
                    Console.WriteLine(h1.HelloWorld);
                    break;
                case Hello2 h2:
                    Console.WriteLine(h2.HelloWorld);
                    break;
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Ref Locals and Returns -----------------");
            int[] arrayInt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ref var referencevar = ref RefLocalsandReturns.FindFromArray(arrayInt);
            Console.WriteLine(referencevar);

            referencevar = 1;

            Console.WriteLine(string.Join(",", arrayInt));

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Digital Separator -----------------");
            Console.WriteLine(123_45_548.23_456);


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Tuples -----------------");

            //method returning a tuple
            (bool bresult, double dcalculation) = Tuples.CalculationTuple();
            Console.WriteLine("{0} - {1}", bresult, dcalculation);

            //value asignation
            (bresult, dcalculation) = (false, 0.5);
            Console.WriteLine("{0} - {1}", bresult, dcalculation);

            //creating a tuple from 2 vars
            int value1 = 1;
            string tittle1 = "value";
            var tuple1 = (value: value1, tittle: tittle1);
            Console.WriteLine("{0} - {1}", tuple1.tittle, tuple1.value);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Throw expressions -----------------");


            object expressionTest = 0;
            var  loadedConfig =  expressionTest ==null ?
                throw new InvalidOperationException("Null Detected") : "Hello Expression";

            Console.WriteLine(loadedConfig);
            Console.Read();

        }        
    }
}
