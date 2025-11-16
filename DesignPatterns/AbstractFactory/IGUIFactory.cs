using DesignPatterns.AbstractFactory.Products;

namespace DesignPatterns.AbstractFactory;

public interface IGUIFactory
{
    public IButton CreateButton();
    public ICheckBox CreateCheckBox();
}