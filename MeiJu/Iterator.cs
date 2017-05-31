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
            ArrayPerson = new Person[Length];//初始化数组的长度
            count = -1;//初始化集合的索引为-1,即第一个元素之前;
        }

        public IEnumerator GetEnumerator()
        {
            return this;//返回一个能循环遍历的集合
        }
        /// <summary>
        /// 取得集合当前的元素
        /// </summary>
        public object Current
        {
            get
            {
                return ArrayPerson[count];
            }
        }
        /// <summary>
        /// 将枚举推进到集合的下一元素;
        /// 循环到集合中的下一个元素
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            int index = ++count;//集合中当前元素的索引(每次都递增++)
            bool result = index < ArrayPerson.Length;
            return result;
        }


        /// <summary>
        /// 将枚举设置为其初始位置,该位置位于集合中第一个元素之前
        /// </summary>
        public void Reset()
        {
            count = -1;
        }
    }
}
