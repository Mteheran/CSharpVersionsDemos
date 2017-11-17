using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Tuples -----------------");

            int value1 = 1;
            string tittle = "value";
            var tuple1 = (value1, tittle);
            Console.WriteLine("{0} - {1}", tuple1.tittle, tuple1.value1);

        

            Console.Read();

        }
    }
}
