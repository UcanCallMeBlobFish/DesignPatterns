namespace ConsoleApp1.FlyWeight;

public class GunFlyweight : IFlyWeight
{
    public Type type { get; set; }
    public string gun { get; set; }

    public GunFlyweight(Type _type)
    {
        type = _type;
        gun = "This is " + type.ToString();
    }
}