using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiJu
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator it = new Iterator(3);
            it.ArrayPerson[0] = new Person("张三",18);
            it.ArrayPerson[1] = new Person("张三", 19);
            it.ArrayPerson[2] = new Person("张三", 108);

            foreach (Person item in it)
            {
                Console.WriteLine(item.Name+item.Age);
            }
        }
    }
}
