using AptitudeTestHandler.Implementation;
using AptitudeTestHandler.InfraStructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AptitudeTestMain
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           .AddTransient<ISumOfBiggestNeighborInArray, SumOfBiggestNeighborInArray>()
           .BuildServiceProvider();
            var sumOfBiggestNeighborInArray = serviceProvider.GetService<ISumOfBiggestNeighborInArray>();

            MainHandler mainClassHandler = new MainHandler(sumOfBiggestNeighborInArray);
            Console.WriteLine("-------- Enter Your Choice! ---------");
            Console.WriteLine("1:  Sum Of Biggest Neighbor Of Array!");
            Console.WriteLine("2:  Implementation Of User Class!");
            Console.WriteLine("3:  Implementation Of Humanoid  Class!");
            Console.WriteLine("4:  Alexa Settings!");
            Console.WriteLine("5:  (Tuple) Method Signature!");
            Console.WriteLine("6:  Construction Game!");
            Console.WriteLine("--------------------------------------");
            int choice = Convert.ToInt32(Console.ReadLine());
            mainClassHandler.HandleMainClassAsync(choice);
            Console.ReadLine();

        }


    }
}
