using DesignPatterns.FactoryMethod.Products.Animals;

namespace DesignPatterns.FactoryMethod.Creators;

public class ConcretePiegon : AnimalCreator
{
    protected override IAnmial FactoryMethod()
    {
        return new Piegon();
    }
}