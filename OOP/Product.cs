namespace OOP;
class Product
{
    private int rate;
    private double _discount;
    public string Title { get; set; }
    public int Price { get; set; }
    public string Brand { get; set; }

    // public string Discount
    // { 
    //     get 
    //     {
    //         return $"{_discount * 100}%";
    //     }
    //     set
    //     {
    //         _discount = double.Parse(value);
    //     }
    // }

    //Arrow Function
    public string Discount
    { 
        get => $"{_discount * 100}%";
        set => _discount = double.Parse(value);
    }
    /// <summary>
    /// Method
    /// </summary>
    /// <param name="_rate"></param>
    // public void SetRate(int _rate)
    // {
    //     rate = _rate;
    // }

    // public string GetRate()
    // {
    //     return $"{rate} stars" ;
    // }

    // public string Rate
    // {
    //     get
    //     {
    //         return $"{rate} stars";
    //     }
    //     set
    //     {
    //         rate = int.Parse(value);
    //     }
    // }
    public string Rate
    {
        get => $"{rate} stars";
        set => rate = int.Parse(value);
    }
}