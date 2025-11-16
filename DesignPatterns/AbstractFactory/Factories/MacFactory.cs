using DesignPatterns.AbstractFactory.Products;

namespace DesignPatterns.AbstractFactory.Factories;

public class MacFactory: IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new MacCheckbox();
    }
}