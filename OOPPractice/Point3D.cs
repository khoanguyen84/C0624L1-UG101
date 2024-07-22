namespace OOPPractice;
class Point3D : Point2D
{
    private float z;

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public Point3D()
    {

    }

    public override string ToString()
    {
        return base.ToString() + $", z = {this.z}";
        // return $"x = {GetX()}, y = {GetY()}, z = {this.z}";
    }
}