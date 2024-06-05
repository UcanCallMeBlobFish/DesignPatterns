namespace ConsoleApp1.Facade;

public class Facade
{
    public void SendMessage(string msg)
    {
        var connect = new Connect();
        var token  = new TokenValidator();
        var server = new Server();

        connect.ConnectServer();
        server.SendMessage(new Message(msg),token);
        connect.Disconnect();
    }
}