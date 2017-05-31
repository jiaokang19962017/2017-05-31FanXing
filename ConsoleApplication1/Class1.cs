using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 数组类
    /// 泛型类,T可以是任何类型
    /// 使用时需要为T指定数据类型
    /// 泛型在编译时不指定数据类型,调用时才指定数据类型
    /// 使用泛型可以实现任何类型的数组
    /// 泛型的优点:1.避免了装箱和拆箱的问题 2.保护了类型安全 
    /// 3.提高了程序性能 4.提高代码的复用性
    /// 泛型不能使用比较运算符
    /// </summary>
    class Class1<T> where T:class  //约束  ,保护数据的完整性
    {
        private T[] array;//定义一个数组
        private int count = 0;//数组下标
        public void Add(T value)//数组添加元素的方法
        {
            array[count] = value;
            count++;
        }
        public T this[int index]//索引器
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public Class1()//构造函数
        {
            array = new T[50];
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
