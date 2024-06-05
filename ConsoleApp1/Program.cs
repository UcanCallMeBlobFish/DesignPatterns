


/*using ConsoleApp1.FlyWeight;
using Type = ConsoleApp1.FlyWeight.Type;

var factory = new FlyWeightFactory();

var first = factory.GetFlyWeight(Type.AKA);

Console.WriteLine(first.type.ToSt*/

using ConsoleApp1.Bridge;



var remotecontroll = new RemoteControl(new SonyTV());
var advancedremo = new AdvancedRemote(new SonyTV());

remotecontroll.turnon();
advancedremo.setchannel(5);