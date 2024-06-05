namespace ConsoleApp1.Decorator;

public class PushingConcreteComponent : IDatabaseComponent
{
    public void PushToDatabase(string abc)
    {
        Console.WriteLine("Pushing abc to database");
    }
}