using Microsoft.Extensions.DependencyInjection;
using System;

//没有领悟IOC要点
namespace IOCPattern
{
    class Program
    {
        static void Main(string[] args)
        {  
            void show()
            {
                Console.WriteLine("我是本地方法");
            } 

            var student1 = (Student)Activator.CreateInstance(typeof(Student),"Neil",28);
            student1.Sleep("2个半");         
                           
            show();
            Console.ReadLine();
        }
    }

    public interface IStudentDailyLife
    {
        public void Study();
        public void Run();
    }

    public class Student : IStudentDailyLife
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Student(string name,int age)
        {
            Age = age;
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine("跑一圈1分钟");
        }

        public void Study()
        {
            Console.WriteLine("学习计算机");
        }
    }

    public static class Extension
    {
        public static void Sleep<T>(this Student student,T time)
        {
            Console.WriteLine($"睡了{time}小时");
        }
    }
}
