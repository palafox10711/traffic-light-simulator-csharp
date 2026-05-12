namespace TrafficLightSimulator;

class Program
{
    static void Main(string[] args)
    {
        var lights = new List<TrafficLight>();
        var system = new TrafficLightSystem(lights);
        var menu = new Menu(lights);

        system.Start();
        menu.Run();

    }
}
