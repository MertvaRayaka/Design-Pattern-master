using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("直接访问Google：");
            Google google = new Google();
            try
            {
                if (!Task.Run(() => google.Search("特朗普")).Wait(1000))
                {
                    Console.WriteLine("访问超时(2S)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("使用代理访问Google：");
            ISearchEngine searchEngine = new GoogleProxy();
            searchEngine.Search("特朗普");

            Console.ReadLine();
        }
    }
}
