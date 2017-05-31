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
            /* Class1 c = new Class1();
             c.Add(8);
             c.Add(9);
             c.Add(10);
             c.PrintLog();*/

            Class1<int> array = new Class1<int>();
            array.Add(12);
            Class1<string> array1 = new Class1<string>();
            array1.Add("字符串");
            array1.PrintLog();
        }
    }
}
