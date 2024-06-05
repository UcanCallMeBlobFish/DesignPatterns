namespace ConsoleApp1.Decorator;

public class CompressDecorator : IDatabaseComponent
{
    private IDatabaseComponent component;

    public CompressDecorator(IDatabaseComponent ccomponent)
    {
        component = ccomponent;
    }
    public void PushToDatabase(string abc)
    {
        throw new NotImplementedException();
    }
}