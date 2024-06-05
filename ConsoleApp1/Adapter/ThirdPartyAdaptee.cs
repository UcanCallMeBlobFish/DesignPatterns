namespace ConsoleApp1.Adapter;

public class ThirdPartyAdaptee
{

    public void init()
    {
        Console.WriteLine("configured");
    }

    public void apply()
    {
        Console.WriteLine("applied");
    }
}