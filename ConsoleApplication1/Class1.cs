using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        private int[] array;//定义一个数组
        private int count = 0;//数组下标
        public void Add(int value)//数组添加元素的方法
        {
            array[count] = value;
            count++;
        }
        public int this[int index]//索引器
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public Class1()//构造函数
        {
            array = new int[50];
        }
       
        public void PrintLog()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
