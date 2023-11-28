

//Interface is a contract
//Classes implement interfaces

List<IComputerController> controllers = new List<IComputerController>();

Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();
BatteryPoweredGameController battery = new BatteryPoweredGameController();
BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

controllers.Add(gameController);
controllers.Add(keyboard);
controllers.Add(battery);

foreach (IComputerController controller in controllers)
{
    if (controller is GameController gc)
    {
        
    }

    if (controller is IBatteryPowered powered)
    {

    }
}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();

powereds.Add(battery);
powereds.Add(batteryKeyboard);

using (GameController gc = new GameController())
{

}

Console.ReadLine();

public interface IComputerController : IDisposable
{
    void Connect();
    void CurrentKeyPressed();
}

public class Keyboard : IComputerController
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        
    }

    public string ConnectionType { get; set; }
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get; set; }
}

public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {
        
    }

    public void CurrentKeyPressed()
    {
        
    }

    public void Dispose()
    {
        // do whatever shutdown tasks needed
    }

}

public class BatteryPoweredGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}