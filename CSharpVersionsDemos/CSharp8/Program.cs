using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CSharp8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Nullable reference types
            string? NullableString = null;

            Console.WriteLine(NullableString?.Length);


            //Ranges and Indices
            int[] intvector = { 0, 1, 2, 3, 4, 5, 6 };
            Index index3 = 3;
            Index index5 = ^2;

            Console.WriteLine($"{intvector[index3]},{intvector[index5]}" );

            //range
            Console.WriteLine($"{string.Join(",",intvector[index3..6])}");

            Console.ReadKey();            
        }     
    }
}
