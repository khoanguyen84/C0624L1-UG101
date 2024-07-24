namespace Abstract;
class Rectangle : Geometry
{
    public int Width { get; set; }
    public int Length { get; set; }

    public Rectangle (string _type): base(_type)
    {

    }
    public override double GetPerimeter()
    {
        return 2 * (Width + Length);
    }

    public override double GetArea()
    {
        return Width * Length;
    }
}