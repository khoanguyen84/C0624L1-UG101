namespace Abstract;
abstract class Geometry
{
    public string Type { get; set; }

    public Geometry(string _type)
    {
        Type = _type;
    }

    public abstract double GetPerimeter();

    public abstract double GetArea();
}