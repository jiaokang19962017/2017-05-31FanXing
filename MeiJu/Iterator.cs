using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiJu
{
    class Iterator:IEnumerable,IEnumerator
    {
        private int length;
        public Person[] ArrayPerson;
        private int count;//集合中当前元素的索引
        public int Length { get { return length; } }

    

        public Iterator()
        {

        }
        public Iterator(int length)
        {
            this.length = length;
            ArrayPerson = new Person[Length];
            count = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;//返回一个能循环遍历的集合
        }
        public object Current
        {
            get
            {
                return ArrayPerson[count];
            }
        }
        public bool MoveNext()
        {
            int index = ++count;
            bool result = index < ArrayPerson.Length;
            return result;
        }


        /// <summary>
        /// 将枚举设置为其初始位置
        /// </summary>
        public void Reset()
        {
            count = -1;
        }
    }
}
