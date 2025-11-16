namespace DesignPatterns.AbstractFactory.Products;

public class WinCheckbox: ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("Windows Checkbox");
    }
}