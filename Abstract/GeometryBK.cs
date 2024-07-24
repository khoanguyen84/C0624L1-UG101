namespace Abstract;
class GeometryBK
{
    public int SideSquare { get; set; }
    public int Radius { get; set; }
    public int LengthRectangle { get; set; }
    public int WidthRectangle { get; set; }
    public string Type { get; set; }

    public GeometryBK(string type)
    {
        Type = type;
    }
    public double GetPerimeter()
    {
        switch (Type)
        {
            case "Square":
                return 4 * SideSquare;
            case "Rectangle":
                return 2 * (LengthRectangle + WidthRectangle);
            case "Cycle":
                return 2 * Math.PI * Radius;
            default:
                return -1;
        }
    }

    public double GetArea()
    {
        switch (Type)
        {
            case "Square":
                return SideSquare * SideSquare;
            case "Rectangle":
                return LengthRectangle * WidthRectangle;
            case "Cycle":
                return Math.PI * Radius * Radius;
            default:
                return -1;
        }
    }
}