namespace ConsoleApp1.Bridge;

public class RemoteControl
{
    protected IDevice _device;

    public RemoteControl(IDevice device)
    {
        _device = device;
    }

    public void turnon()
    {
        _device.TurnOn();
    }

    public void turnof()
    {
        _device.TurnOf();
    }
}