using Microsoft.Extensions.DependencyInjection;
using System;

namespace MiniDIDemo
{
    class Program
    {
        public static IServiceProvider Provider { get; set; }
            = new ServiceCollection()
                  .AddTransient<IUser, UsersService>()
                  .AddSingleton<ICar, CarService>()
                  .BuildServiceProvider();
        static void Main(string[] args)
        {
            A a = new A(Provider.GetService<IUser>());
            B b = new B(Provider.GetService<IUser>());
            a.User.MyName();
            a.User.MyCarName("BMW");
            b.User.MyName();
            b.User.MyCarName("Benz");

            Console.ReadKey();
        }
    }

    public class A
    {
        public IUser User { get; set; }
        public A(IUser user)
        {
            User = user;
            User.Name = "Neil";
        }
    }

    public class B
    {
        public IUser User { get; set; }
        public B(IUser user)
        {
            User = user;
            User.Name = "Amber";
        }
    }
}
