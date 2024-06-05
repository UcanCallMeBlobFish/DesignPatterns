namespace ConsoleApp1.Composite;

public class Composite : IComposite
{
    public List<IComposite> group = new List<IComposite>();
    
    public void SendHelp()
    {
        foreach (var c in group)
        {
            c.SendHelp();    
        }
    }
}