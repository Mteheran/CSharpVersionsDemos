using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            Console.Read();
        }
    }
}
