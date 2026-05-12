namespace TrafficLightSimulator;

class TrafficLightSystem
{
    private List<TrafficLight> _lights;

    public TrafficLightSystem(List<TrafficLight> lights)
    {
        _lights = lights;
    }

    public void Start()
    {
        var thread = new Thread(() =>
        {
            while (true)
            {
                Thread.Sleep(2000);
                lock (_lights)
                {
                    foreach( var light in _lights)
                    {
                        light.NextColor();
                    }
                }
            }
        });
        thread.IsBackground = true;
        thread.Start();
    }
}