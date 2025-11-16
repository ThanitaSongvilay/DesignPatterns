namespace DesignPatterns.AbstractFactory.Products;

public class MacButton: IButton
{
    public string Paint()
    {
        return "MacButton";
    }
}