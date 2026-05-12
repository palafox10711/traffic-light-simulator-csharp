namespace TrafficLightSimulator;
class Menu
{
    private List<TrafficLight> _lights;
    private int _nextId = 1;
    public Menu(List<TrafficLight> lights)
    {
        _lights = lights;
    }
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
                    var light = _lights.FirstOrDefault(l => l.Id == removeInput);
                    if (light == null)
                    {
                        Console.WriteLine("Invalid id, try again");
                    }
                    else
                    {
                        _lights.Remove(light);
                        Console.WriteLine($"Traffic Light with (Id - {removeInput}) removed");
                    
                    }
                    break;
                case "3":
                    if (_lights.Count == 0)
                    {
                        Console.WriteLine("No traffic lights added yet.");
                        break;
                    }
                    foreach(TrafficLight tl in _lights)
                    {
                        Console.WriteLine($"Road: {tl.Id} - Color: {tl.Color}");
                    }
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