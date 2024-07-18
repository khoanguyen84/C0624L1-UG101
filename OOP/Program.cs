namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        #region 
        // <class_name> <object_name> = new <class_name> ();
        // Car toyota = new Car();
        // toyota.Color = "Red"; //setter
        // toyota.Price = 10000;
        // Console.WriteLine($"Color = {toyota.Color} Price = {toyota.Price}");
        // toyota.Color = "Yellow";
        // toyota.Price = 12000;
        // Console.WriteLine($"Color = {toyota.Color} Price = {toyota.Price}");
        #endregion

        // Shoes nike = new Shoes(41, 500);
        // nike.Brand = "Nike";
        // nike.GetInfo();
        // Console.Write($"Size = {nike.Size}, Price = {nike.Price}, Brand = {nike.Brand}");

        // Shoes adidas = new Shoes(39, 550);
        // adidas.Brand = "Adidas";
        // adidas.GetInfo();

        // Shoes fuma = new Shoes(25, 600);
        // fuma.GetInfo();

        // Shoes snaker = new Shoes();
        Staff khoa = new Staff("Khoa Nguyen");
        Staff nhi = new Staff("Nhi Nguyen", 18);
        Staff trung = new Staff();
        Console.WriteLine(khoa.Fullname);
        Console.WriteLine("=============");
    }
}
