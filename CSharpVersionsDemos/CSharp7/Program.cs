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


            Console.Read();
        }
    }
}
