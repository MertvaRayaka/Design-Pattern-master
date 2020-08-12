using System;

//让用户通过特定的接口访问容器的数据，不需要了解容器内部的数据结构。
namespace IteratorPattern
{   
    // 迭代器抽象类
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }

    // 抽象聚合类
    public interface IListCollection
    {
        Iterator GetIterator();
    }

    // 具体迭代器类
    public class ConcreteIterator : Iterator
    {
        // 迭代器要集合对象进行遍历操作，自然就需要引用集合对象
        private ConcreteList list;
        private int index;

        public ConcreteIterator(ConcreteList list)
        {
            this.list = list;
            index = 0;
        }

        public bool MoveNext()
        {
            if (index < list.Length)
            {
                return true;
            }
            return false;
        }

        public Object GetCurrent()
        {
            return list.GetElement(index);
        }

        public void Reset()
        {
            index = 0;
        }

        public void Next()
        {
            if (index < list.Length)
            {
                index++;
            }
        }
    }

    // 具体聚合类
    public class ConcreteList : IListCollection
    {
        readonly string[] collection;
        public ConcreteList()
        {
            collection = new string[] { "A", "B", "C", "D" };
        }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public string GetElement(int index)
        {
            return collection[index];
        }
    }
}
