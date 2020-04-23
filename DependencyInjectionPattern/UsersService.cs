using System;

namespace MiniDIDemo
{
    public class UsersService : IUser
    {
        public ICar _carService;

        public string Name { get ; set ; }

        public UsersService(ICar carInterface)
        {
            _carService = carInterface;
        }


        public void MyName()
        {
            Console.WriteLine("我的名字是："+ Name);
        }

        public void MyCarName(string str)
        {
            Console.Write("我的汽车是：");
            _carService.ShowName(str);
        }

    }
}
