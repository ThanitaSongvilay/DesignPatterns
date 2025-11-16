using DesignPatterns.AbstractFactory.Factories;

namespace DesignPatterns.AbstractFactory;

public class AbstractFactoryClient
{
    public void Main()
    {
        // The client code can work with any concrete factory class.
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new WinFactory());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new MacFactory());
    }

    public void ClientMethod(IGUIFactory factory)
    {
        var productA = factory.CreateButton();
        var productB = factory.CreateCheckBox();
        
        Console.WriteLine(productA.Paint());
        productB.Paint();
    }
}