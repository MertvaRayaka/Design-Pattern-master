using System;

namespace MiniDIDemo
{
    public class CarService : ICar
    {
        public void ShowName(string str)
        {
            Console.WriteLine(str);
        }
    }
}
