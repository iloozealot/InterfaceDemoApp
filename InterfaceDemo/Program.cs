

//Interface is a contract
//Classes implement interfaces

List<IComputerController> controllers = new List<IComputerController>();

Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();

controllers.Add(gameController);
controllers.Add(keyboard);

foreach (IComputerController controller in controllers)
{
    
}

using (GameController gc = new GameController())
{

}

Console.ReadLine();

public interface IComputerController
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

    public string ConnectionType { get; set; }
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

    public int BatteryLevel { get; set; }
}