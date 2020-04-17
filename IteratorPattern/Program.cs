using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = (MyClass)Activator.CreateInstance(typeof(MyClass));

            foreach (var item in mc)
            {
                Console.WriteLine(item);
            }

            foreach (var car in mc.IteratorMethod())
            {
                Console.WriteLine(car.CarAge);
                Console.WriteLine(car.CarBrand);
            }                      

            //Console.WriteLine("迭代器模式：");
            //IListCollection list = new ConcreteList();
            //var iterator = list.GetIterator();

            //while (iterator.MoveNext())
            //{
            //    string str = (string)iterator.GetCurrent();
            //    Console.WriteLine(str);
            //    iterator.Next();
            //}

            Console.Read();
        }
    }
}
