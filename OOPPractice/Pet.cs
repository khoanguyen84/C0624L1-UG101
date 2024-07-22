namespace OOPPractice;
class Pet : Object
{
    public string EyeColor { get; set; }
    public double Age { get; set; }
    public double Weight { get; set; }
    public string Location { get; set; }

    public Pet(string eyeColor, double weight)
    {
        EyeColor = eyeColor;
        Weight = weight;
    }
    public string Eat()
    {
        return "Eat food";
    }

    public string Sleep(int timeLength)
    {
        return $"Pet sleep {timeLength}";
    }

    public virtual string Speak()
    {
        return "speak sound";
    }

    public virtual string Move()
    {
        return "Pet moving";
    }
}