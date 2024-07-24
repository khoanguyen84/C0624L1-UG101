namespace Abstract;
class Square : Geometry
{
    public int Side { get; set; }

    public Square (string _type) : base(_type)
    {

    }

    public override double GetPerimeter()
    {
        return 4 * Side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }
}