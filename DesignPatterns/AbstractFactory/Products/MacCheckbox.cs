namespace DesignPatterns.AbstractFactory.Products;

public class MacCheckbox: ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("MacCheckbox");
    }
}