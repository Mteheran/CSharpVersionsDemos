using System;

namespace CSharp7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leading underscores in numeric literals
            int binaryValue = 0b_0101_0101;
                       

            //Conditional ref expressions
            ref double GetMajorValue(ref double number1, ref double number2)
            {
                return ref(number1 > number2 ? ref number1 : ref number2);
            }

            double value1 = 3;
            double value2 = 7;

            ref var r = ref GetMajorValue(ref value1, ref value2);

            Console.ReadKey();
        }
    }
}
