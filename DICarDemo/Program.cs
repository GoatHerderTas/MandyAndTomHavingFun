using Microsoft.Extensions.DependencyInjection;
using System;

namespace DICarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IEngineService, BetterEngine>()
                .AddSingleton<Car, Car>()
                .BuildServiceProvider();


            //Create car
            // IEngineService es1 = new EngineService();
            //Car car = new Car(es1);
            //IEngineService es2 = new BetterEngine();
            //Car car = new Car(es2);

            Car car = serviceProvider.GetService<Car>();

            string result = car.MoveForward();
            Console.WriteLine(result);
            result = car.MoveBackward();
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
