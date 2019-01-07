using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuples support == and !=
            var mytuple = (5, "Text");

            Console.WriteLine($"{(mytuple == (10, "Text") ? "Are equals" : "Are not equals" )}");
            
            Console.ReadKey();
        }
    }

        public class B
        {
            //Extend expression variables in initializers
            public B(int i, out int j)
            {
                j = i;
            }
        }

        public class D : B
        {
            //Extend expression variables in initializers
            public D(int i) : base(i, out var j)
            {
                Console.WriteLine($"The value of 'j' is {j}");
            }
        }
}
