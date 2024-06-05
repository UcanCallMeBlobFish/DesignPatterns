namespace ConsoleApp1.Bridge;

public class SonyTV : IDevice
{
    
    public void TurnOn()
    {
       Console.WriteLine("Sony Turned ON");
    }

    public void TurnOf()
    {
        Console.WriteLine("Sony Turned Off");
    }

    public void SetChannel(int a)
    {
        Console.WriteLine("Sony switched to" + a);
    }
}