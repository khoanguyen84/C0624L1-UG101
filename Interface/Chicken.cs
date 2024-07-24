namespace Interface;
class Chicken : Animal, IEdible
{
    public void HowToEat()
    {
        Console.Write("Fire");
    }

    public override void MakeSound()
    {
        Console.Write("Chip chip");
    }
}