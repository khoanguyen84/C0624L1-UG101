namespace Abstract;
class Triangle : Geometry
{
    public int Side_1 { get; set; }
    public int Side_2 { get; set; }
    public int Side_3 { get; set; }
    public int Height { get; set; }

    public Triangle(string _type) : base(_type)
    {

    }

}