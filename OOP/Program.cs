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
        // Staff khoa = new Staff("Khoa Nguyen");
        // Staff nhi = new Staff("Nhi Nguyen", 18);
        // nhi.SetDob(DateTime.Parse("10/10/2000"));
        // Console.WriteLine(nhi.GetDob());
        // Staff trung = new Staff();
        // Console.WriteLine(khoa.Fullname);
        // Console.WriteLine("=============");

        // Product shoes = new Product();
        // shoes.Brand = "Nike";
        // Console.WriteLine(shoes.Title);
        // shoes.SetRate(5);
        // Console.WriteLine(shoes.GetRate());

        // shoes.Discount = "0.2";
        // Console.WriteLine(shoes.Discount);

        Staff khoa = new Staff();
        khoa.Mobile = "0935216417";
        Console.WriteLine(khoa.Mobile);
    }


    // Access modifier
    // Public 
    // internal (default)
    // private => bên trong class mới được truy cập
    // protected => những class mối quan hệ với nhau mới truy cập được
}
