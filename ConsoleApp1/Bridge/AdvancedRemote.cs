namespace ConsoleApp1.Bridge;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void setchannel(int a)
    {
        _device.SetChannel(a);
    }
}