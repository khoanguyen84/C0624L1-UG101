namespace OOPPractice;
class Bird : Pet
{
    public string FeatherColor { get; set; }
    public Bird(string eyeColor, double weight, string featherColor) : base(eyeColor, weight)
    {
        FeatherColor = featherColor;
    }

    // public Bird()
    // {

    // }
    public string Fly()
    {
        return "Bird moves by fling";
    }

    public override string Speak()
    {
        return base.Speak() + " Quat quat";
    }

    public string BirdMove()
    {
        return "Bird moves by fling";
    }
}