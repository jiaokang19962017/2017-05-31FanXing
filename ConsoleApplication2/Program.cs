﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pd = new Product(2.3);
           int sele =  pd.ComperTo(pd);
            Console.WriteLine(sele);
        }
    }
}
