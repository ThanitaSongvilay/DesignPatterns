namespace DesignPatterns.FactoryMethod.Products.Animals;

public class Piegon : IAnmial
{
    public string SayHello()
    {
        return "Piegon";
    }

    public string Eat()
    {
        return "Bread crumbs nom nom";
    }
}