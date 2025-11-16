using DesignPatterns.AbstractFactory.Products;

namespace DesignPatterns.AbstractFactory.Factories;

public class WinFactory: IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }
    
    public ICheckBox CreateCheckBox()
    {
        return new WinCheckbox();
    }
}