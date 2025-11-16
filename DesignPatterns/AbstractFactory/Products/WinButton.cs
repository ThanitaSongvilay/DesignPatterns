namespace DesignPatterns.AbstractFactory.Products;

public class WinButton: IButton
{
    public string Paint()
    {
        return "Windows button";
    }
}