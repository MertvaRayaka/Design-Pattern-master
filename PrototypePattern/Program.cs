using System;

//测试GitHub
//原型模式
namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Email src = (Email)Activator.CreateInstance(typeof(Email));
            var ShallowClone = src.ShallowClone() as Email;
            var DeepClone = src.DeepClone() as Email;

            src.Length = 20;
            src.Address = "Y";
            src.person.Name = "Amber";

            Console.ReadLine();
        }
    }
}
