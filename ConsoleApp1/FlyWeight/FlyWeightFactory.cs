namespace ConsoleApp1.FlyWeight;

public class FlyWeightFactory
{
    private Dictionary<Type, IFlyWeight> flyweightguns = new Dictionary<Type, IFlyWeight>();

    public IFlyWeight GetFlyWeight(Type type)
    {
        if (!flyweightguns.ContainsKey(type))
        {
            flyweightguns[type] = new GunFlyweight(type);
        }

        return flyweightguns[type];
    }
}