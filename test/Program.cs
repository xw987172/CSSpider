using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addi = (x, y) => x * y;
            int a = addi(2, 3);
            Console.WriteLine(a);
        }
    }
}
