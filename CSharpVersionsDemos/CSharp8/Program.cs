using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;


namespace CSharp8
{
    class Program
    {
        static int myvar = 0;
        static async Task Main(string[] args)
        {
            // Nullable reference types
            string? NullableString = null;

            Console.WriteLine(NullableString?.Length);


            //Ranges and Indices
            int[] intvector = { 0, 1, 2, 3, 4, 5, 6 };
            Index index3 = 3;
            Index index5 = ^2;

            //Console.WriteLine($"{intvector[index3]},{intvector[index5]}" );

            //range
            //Console.WriteLine($"{string.Join(",",intvector[index3..6])}");

            //switch as expression
            int intValueForSwitch = 0;
            var state = (intValueForSwitch) switch
            {
                (0) => "Cero",
                (1) => "Uno",
                (2) => "Dos",
                _ => "No es un numero valido"

            };

            //Property patterns 
            DateTime dateTime = new DateTime();

            if (dateTime is DateTime { Day:1 })
            {

            }

            object myObject = null;


            if (myObject is DateTime { Hour: 10 })
            {

            }


            //static local function
            static void LocalFunction()
            {
                Console.WriteLine($"Inside LocalFunction, input {myvar} ");
            }


            //Using declaration
            using (var reader = new StreamReader("C:/MyFile.txt"))
            {
                var contents = reader.ReadToEnd();
                Console.WriteLine($"Read {contents.Length} characters from file.");
            }

            //new way 
            using var readerNew = new StreamReader("C:/MyFile.txt");
            var contentsNew = readerNew.ReadToEnd();
            Console.WriteLine($"Read {contentsNew.Length} characters from file.");


            Console.ReadKey();            
        }     
    }
}
