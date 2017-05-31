using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.Add(8);
            c.Add(9);
            c.Add(10);
            c.PrintLog();
        }
    }
}
