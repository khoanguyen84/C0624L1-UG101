namespace FileDemo;

class Program
{
    public static string path = @"D:\CGO\C0624L1-UG101\FileDemo\Data";
    public static string filename = "account.txt";
    public static string fileLog = "log.txt";
    // public static string url = $"{path}\\{filename}";
    public static string url = Path.Combine(path, filename);
    // D:\CGO\C0624L1-UG101\FileDemo\Data\account.txt
    static void Main(string[] args)
    {
        // FileStream fileStream = new FileStream(url, FileMode.Append);
        // using(StreamWriter writer = new StreamWriter(fileStream))
        // {
        //     writer.WriteLine("Khoa Nguyen");
        //     writer.WriteLine("khoa.nguyen@codegym.vn");
        //     writer.WriteLine("0935216417");
        // }

        // try
        // {
        //     Console.Write("Enter number = ");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     int divisor = 0;
        //     Console.WriteLine(number/divisor);
        //     Console.WriteLine(number/divisor);
        // }
        // catch (System.Exception ex)
        // {
        //     Console.WriteLine("Something went wrong");
        //     // Ghi log
        //     FileStream fs = new FileStream(Path.Combine(path, fileLog), FileMode.Append);
        //     using(StreamWriter write = new StreamWriter(fs))
        //     {
        //         write.WriteLine($"[ERROR]: {DateTime.UtcNow.Date.ToLongDateString()} - {ex.Message}");
        //     }
        // }

        // khi làm việc với ghi file
        // bước 1: mở file (nếu tồn tại file), tạo file mới file
        // bước 2: ghi dữ liệu vào file (lặp 1 số lần)
        // bước 3: đóng file đó lại

        // khi làm việc với đọc file
        // bước 1: mở file (nếu tồn tại file), tạo file mới file
        // bước 2: đọc toàn bộ hoặc đọc từng dòng
        // bước 3: đóng file đó lại
        ShowLog();
    }

    public static void ShowLog()
    {
        FileStream fs = new FileStream(Path.Combine(path, fileLog), FileMode.Open);
        string line;
        using (StreamReader reader = new StreamReader(fs))
        {
            while((line = reader.ReadLine()) != null)
             Console.WriteLine($"* - {line}"); 
        }
    }
}
