using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersionsDemos
{
    public static class OutParameters
    {
        public static void DemoOutParameters(out string tittle, out string message)
        {
            tittle = "Demo Out Parameters";
            message = "this is a demo using var type of out  without create them before";
        }
    }
}
