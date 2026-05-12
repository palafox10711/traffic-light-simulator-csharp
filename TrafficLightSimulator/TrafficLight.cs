using System.Security.Authentication.ExtendedProtection;

namespace TrafficLightSimulator;
class TrafficLight{
    
    public int Id {get; private set;}
    public LightColor Color {get; private set;}

    public TrafficLight(int id)
    {
        Id = id;
        Color = LightColor.Red;
        
    }

    public void NextColor()
    {
        switch(Color)
        {
            case LightColor.Red: 
                Color = LightColor.Green;
                break;
            case LightColor.Green: 
                Color = LightColor.Yellow;
                break;
            case LightColor.Yellow: 
                Color = LightColor.Red;
                break;
            default: throw new Exception ("color invalido");   
        }
    }
}