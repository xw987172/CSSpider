using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text;
            text = string.Empty;
            for (i = 0; i < 5; i++)
            {
                text = string.Format("line {0},{1}", Convert.ToString(i),"han");
            }
            Debug.WriteLine("debug 1","Main");
            Trace.WriteLine("debug 1", "Main");
            Console.WriteLine(text);#111
        }
    }
}
