namespace Abstract;
class Cycle : Geometry
{
    public int Radius { get; set; }

    public Cycle(string _type) : base(_type)
    {

    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}