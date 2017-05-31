using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanXingTest
{
    class Class1<T>
    {
        public  void add<T>(T a, T b)
        {
            Console.WriteLine("{0}+{1}={2}",a.ToString(),b.ToString(),double.Parse(a.ToString())+double.Parse(b.ToString()));
        }
    }
}
