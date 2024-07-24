namespace Abstract;

class Program
{
    static void Main(string[] args)
    {
        #region 
        // GeometryBK cycle = new GeometryBK("Cycle");
        // cycle.Radius = 10;
        // Console.WriteLine($"Cycle Perimeter = {cycle.GetPerimeter()}, Area = {cycle.GetArea()}");

        // GeometryBK square = new GeometryBK("Square");
        // square.SideSquare = 5;
        // Console.WriteLine($"Square Perimeter = {square.GetPerimeter()}, Area = {square.GetArea()}");

        // GeometryBK rectangle = new GeometryBK("Rectangle");
        // rectangle.WidthRectangle = 20;
        // rectangle.LengthRectangle = 10;
        // Console.WriteLine($"Rectangle Perimeter = {rectangle.GetPerimeter()}, Area = {rectangle.GetArea()}");
        #endregion

        Cycle cycle = new Cycle("Cycle");
        cycle.Radius = 10;
        Console.WriteLine($"Cycle Perimeter = {cycle.GetPerimeter()}, Area = {cycle.GetArea()}");

        Square square = new Square("Square");
        square.Side = 5;
        Console.WriteLine($"Square Perimeter = {square.GetPerimeter()}, Area = {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Rectangle");
        rectangle.Width = 20;
        rectangle.Length = 10;
        Console.WriteLine($"Rectangle Perimeter = {rectangle.GetPerimeter()}, Area = {rectangle.GetArea()}");
        Triangle triangle = new Triangle("Triangle");
        triangle.Side_1 = 5;
        triangle.Side_1 = 15;
        triangle.Side_1 = 7;
        Console.WriteLine($"Triangle Perimeter = {triangle.GetPerimeter()}, Area = {triangle.GetArea()}");

        // Geometry geometry = new Geometry("Geometry");
        // Console.WriteLine($"Geometry Perimeter = {geometry.GetPerimeter()}, Area = {geometry.GetArea()}");

    }
}
