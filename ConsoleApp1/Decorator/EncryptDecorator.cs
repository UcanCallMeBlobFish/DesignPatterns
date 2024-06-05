namespace ConsoleApp1.Decorator;

public class EncryptDecorator : IDatabaseComponent
{
    private IDatabaseComponent component;

    public EncryptDecorator(IDatabaseComponent ccomponent)
    {
        component = ccomponent;
    }
    public void PushToDatabase(string abc)
    {
        abc += "Encrypted";
        component.PushToDatabase(abc);
    }
}