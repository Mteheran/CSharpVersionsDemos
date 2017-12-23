using System;
using System.Threading.Tasks;
using static System.Console; // using static 

namespace CSharp6
{
    class Program
    {

        public string MyVar { get; set; } = "Hello World"; //Auto Property Initializer 

        public string MyVarExpresion  => string.Format("Hello World at:{0}", DateTime.Now);  //value of property as expression

        static void Main(string[] args)
        {
            //null-conditional operator
            WriteLine("---------------------- Null-Conditional Operator -----------------");

            DateTime? datetime = new DateTime();

            var YearOfDate = datetime?.Year; //using ? asking if the value is null

            WriteLine(YearOfDate);

            var YearOfDateConditional = datetime?.Year ?? 0; //using ? asking if the value is null and if the property Year is null returning 0

            WriteLine(YearOfDateConditional);

            WriteLine("-----------------------------------------------------------");

            //String Interpolation
            WriteLine("----------------------String Interpolation -----------------");

            var years = $"YearOfDate:{YearOfDate} - YearOfDateConditional:{YearOfDateConditional}"; //adding vars on the string easily 

            WriteLine(years);

            Read();
        }


        //Expression-Bodied Function
        public int Sum2Numbers(int x, int y) => (x + y);

        public async Task  AnyMethod()
        {
            try
            {

            }
            catch (Exception ex) when (ex.Message.Contains("Something")) // Exception Filter
            {

                await CatchMethod(); 
            }
        }

        private async Task CatchMethod()
        {
            WriteLine("Exception occured");
        }

    }
}
