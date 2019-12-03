using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel.BOL;
using Personnel.Services;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SiretValidator test = new SiretValidator();
            string value = "12345678200012";
            bool result = test.IsValid(value);
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
