using System;

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

            Console.WriteLine(string.Join(",",arrayInt));
            Console.WriteLine("-----------------------------------------------------------");         



            Console.WriteLine("---------------------- Digital Separator -----------------");
            Console.WriteLine(123_45_548.23_456);




            Console.Read();
        }
    }
}
