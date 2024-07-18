namespace OOP;
class Staff
{
    public string Fullname { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; }

    public Staff()
    {
        Console.WriteLine("Execute Constructor without parameter");
    }
    public Staff(string fullname)
    {
        Fullname = fullname;
        Console.WriteLine("Execute Constructor 1 parameter");
    }
    public Staff(string fullname, int age)
    {
        Fullname = fullname;
        Age = age;
        Console.WriteLine("Execute Constructor 2 parameters");
    }
}