namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Trainer khoa = new Trainer();
        Console.WriteLine(khoa.DateOfBirth);
        Console.WriteLine(khoa.Fullname);
        Console.WriteLine(khoa.Gender);
        Console.WriteLine(khoa.WorkerCode);
        Console.WriteLine(khoa.Salary);

        Student bao = new Student();
        Console.WriteLine(bao.DateOfBirth);
        Console.WriteLine(bao.Fullname);
        Console.WriteLine(bao.Gender);
        Console.WriteLine(bao.StudentCode);

        Staff chanh = new Staff();
        Console.WriteLine(chanh.Email);
    }
}
