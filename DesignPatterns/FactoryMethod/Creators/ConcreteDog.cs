namespace DesignPatterns.FactoryMethod.Creators;

public class ConcreteDog: AnimalCreator
{
    protected override IAnmial FactoryMethod()
    {
        return new Dog();
    }
}