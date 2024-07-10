namespace Method;
class Naming
{
    static void Main(string[] args)
    {
        // Naming paramenter
        // GetProfile("28 NTP", 18, true, DateTime.Parse("10/10/2000"), "Khoa Nguyen");
        // GetProfile(age: 18, dob: DateTime.Parse("02/02/2000"), gender: false, fullname: "Khoa Nguyen", address: "28 NTP");
        double result_1 = Math.Pow(y: 3, x: 2);
        double result_2 = Math.Pow(3, 2);
        Console.WriteLine($"result_1 = {result_1}");
        Console.WriteLine($"result_2 = {result_2}");
    }

    static void GetProfile(string fullname, int age, bool gender, DateTime dob, string address)
    {
        Console.WriteLine("Full information");
        Console.WriteLine($"Fullname: {fullname}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Dob: {dob.Date.ToShortDateString()}");
        Console.WriteLine($"Address: {address}");
    }
}