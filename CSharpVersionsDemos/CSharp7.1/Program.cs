using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp7._1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Tuples -----------------");

            int value1 = 1;
            string tittle = "value";
            var tuple1 = (value1, tittle);
            Console.WriteLine("{0} - {1}", tuple1.tittle, tuple1.value1);


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------- Async main method -----------------");

            HttpClient client = new HttpClient();

            //now you can use await
            string getStringTask = await client.GetStringAsync("http://msdn.microsoft.com");



            Console.Read();

        }
    }
}
