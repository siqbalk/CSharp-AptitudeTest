using AptitudeTestHandler;
using AptitudeTestHandler.DesignPattern.AbstractFactoryDesignPattern;
using AptitudeTestHandler.Implementation;
using AptitudeTestHandler.InfraStructure;
using AptitudeTestHandler.Tuple;
using System;

namespace AptitudeTestMain
{
    public class MainHandler
    {
        private ISumOfBiggestNeighborInArray _sumOfBiggestNeighborInArray;


        public MainHandler(ISumOfBiggestNeighborInArray sumOfBiggestNeighborInArray)
        {
            _sumOfBiggestNeighborInArray = sumOfBiggestNeighborInArray;
        }
        public void HandleMainClassAsync(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter Array Size");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    if (arraySize < 2)
                    {
                        Console.WriteLine("Array Length must be greater or equal to 2 ");
                        break;
                    }
                    int[] arrA = new int[arraySize];
                    Console.WriteLine("Enter Array Elements:");
                    for (int i = 0; i < arrA.Length; i++)
                    {
                        arrA[i] = int.Parse(Console.ReadLine());
                    }
                    _sumOfBiggestNeighborInArray.Challenge(arrA);
                    break;
                case 2:
                    while (true)
                    {
                        var user = new User();
                        Console.WriteLine("please eneter the username , or q to exit");
                        var userName = Console.ReadLine();
                        if (userName == "q")
                        {
                            break;
                        }
                        user.Add(userName);
                        Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
                    }
                    break;
                case 3:
                    var john = new Humanoid(new Dancing());
                   // Console.WriteLine(john.); //print dancing
                    var alex = new Humanoid(new Cooking());
                    //Console.WriteLine(alex.ShowSkill());//print cooking
                    var bob = new Humanoid();
                    //Console.WriteLine(bob.ShowSkill());//print
                    break;
                case 4:
                    var alexa = new Alexa();
                    Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
                    alexa.Configure(x =>
                    {
                        x.OwnerName = "Bob Marley";
                        x.GreetingMessage = $"Hello {x.OwnerName}, Im at your service";
                    }
                   );
                    Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, Im at your service
                    Console.WriteLine("press any key to exit ...");
                    Console.ReadKey();
                    break;
                case 5:
                    var (averageSalary, numberOfEmployee) = Calculation.SomeCalculation(0L, 10, 0L == 10L);
                    break;
                case 6:
                    var myHouse = new Building().AddKitchen()
                   .AddBedroom("master")
                   .AddBedroom("guest")
                   .AddBalcony();
                    var normalHouse = myHouse.Build();
                    //kitchen, master room, guest room, balcony
                    Console.WriteLine(normalHouse.Describe());
                    myHouse.AddKitchen().AddBedroom("another");
                    var luxuryHouse = myHouse.Build();
                    //it only shows the kitchen after build
                    //kitchen, master room, guest room, balcony, kitchen, another room
                    Console.WriteLine(luxuryHouse.Describe());
                    break;
            }
        }


    }
}
