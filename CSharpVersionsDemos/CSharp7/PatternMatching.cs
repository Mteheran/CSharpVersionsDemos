using System;

namespace CSharpVersionsDemos
{
    public static class PatternMatching
    {
        public static object GetPattern()
        {
            //creating random object type
            if (new Random(DateTime.Now.Millisecond).Next(1, 5) > 2)
                return new Hello1();
            else
                return new Hello2();
        }
    }

    public class Hello1
    {
        public string HelloWorld;

        public Hello1()
        {
            HelloWorld = "Hello World from Hello1";
        }
    }

    public class Hello2
    {
        public string HelloWorld;

        public Hello2()
        {
            HelloWorld = "Hello World from Hello2";
        }
    }
}
