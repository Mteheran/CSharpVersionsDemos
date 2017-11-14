using System;

namespace CSharpVersionsDemos
{
    public static class RefLocalsandReturns
    {
        public static ref int FindFromArray(int[] intarray)
        {           
            return ref intarray[new Random(DateTime.Now.Millisecond).Next(1, 10)];
        }        
    }
}
