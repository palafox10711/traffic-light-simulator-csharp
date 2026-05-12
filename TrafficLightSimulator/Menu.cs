using System.Runtime.InteropServices.Marshalling;
namespace TrafficLightSimulator;


class Menu
{
    private List<TrafficLight> _lights = new List<TrafficLight>();
    private int _nextId = 1;
    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Welcome to the traffic management system!");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. System");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Write a number: ");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _lights.Add(new TrafficLight(_nextId));
                    Console.WriteLine($"Traffic light added (id = {_nextId})");
                    _nextId++;
                    break;
                case "2":
                    Console.WriteLine("Which traffic light do you want to remove");
                    if ( ! int.TryParse(Console.ReadLine(), out int removeInput)){
                        Console.WriteLine("please, enter a valid number");
                        break;
                    }
                    
                    if (removeInput < 1 || removeInput > _lights.Count)
                    {
                        Console.WriteLine("Invalid id. Try again.");
                    }
                    else
                    {
                        _lights.RemoveAt(removeInput - 1);
                        Console.WriteLine($"Traffic light {removeInput} removed.");
                    }
                    break;
                case "3":
                    Console.WriteLine("System");
                    break;
                case "0":
                    Console.WriteLine("Exiting...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}