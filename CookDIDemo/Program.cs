using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CookDIDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IOvenService, OvenService>()
                .AddSingleton<CookApp, CookApp>()
                .BuildServiceProvider();

            //IOvenService os = new OvenService();
            //CookApp cook = new CookApp(os);

            CookApp cook = serviceProvider.GetService<CookApp>();

            Console.WriteLine(cook.cook("potatoe"));

        }
       
    }
}
