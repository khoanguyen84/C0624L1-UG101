namespace OOPPractice;
class Duck : Pet
{
    public Duck(string eyeColor, double weight) : base(eyeColor, weight)
    {

    }

    public override string Move()
    {
        return "Duck moves by 2 legs";
    }
}