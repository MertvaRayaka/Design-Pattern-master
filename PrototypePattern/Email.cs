using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable]
    public class Email : BaseClone<Email>
    {
        public int Length { get; set; } = 10;//值类型
        public string Address { get; set; } = "X";//不可变的引用类型
        public Person person { get; set; } = new Person() { Age = 25, Name = "Neil" };//引用类型

        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }

        public new object DeepClone()
        {
            return base.DeepClone();
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    [Serializable]
    public class BaseClone<T>
    {

        public virtual T DeepClone()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            return (T)formatter.Deserialize(memoryStream);
        }
    }

}
