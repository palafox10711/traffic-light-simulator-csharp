using System.Runtime.InteropServices.Marshalling;
namespace TrafficLight;
class Menu{
public void Run(){
    bool isRunning = true;

    while(isRunning){
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
    case "1": Console.WriteLine("agregar...");
        break;
    case "2": Console.WriteLine("borrar..");
        break;
    case "3": Console.WriteLine("System");
        break;
    case "0": Console.WriteLine("saliendo");
    isRunning = false;
        break;
    default: System.Console.WriteLine("error agrag un numero valido");
        break;
}
    }
}

    
}