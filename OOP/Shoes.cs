namespace OOP;
class Shoes
{
    /// <summary>
    /// Properites
    /// </summary>
    public int Size { get; set; }
    public int Price { get; set; }
    public string Brand { get; set; }

    //Nếu LTV ko định nghĩa Constructor thì mặc định sẽ có 1 constructor như sau
    public Shoes() 
    {

    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="size"></param>
    /// <param name="price"></param>
    public Shoes(int size, int price)
    {
        this.Size = size;
        this.Price = price;
    }
    
    /// <summary>
    /// Methods
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine($"Size = {this.Size}, Price = {this.Price}, Brand = {this.Brand}");
    }
}

// this ~ context (ngữ cảnh)
// Ai lên giới thiệu thì gồm 3 thông tin
// 1. Họ và tên
// 2. Ngày sinh
// 3. Giới tính