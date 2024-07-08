namespace Method;

class Program
{
    static void Main(string[] args)
    {
        #region 
        // copy/gõ lại => mất thời gian
        // mã nguồn dài dòng
        // cập nhật => làm đồng loạt (lặp lại các nơi khác)
        // tái sử dụng

        // PrintThreeHelloWorld();
        /*
            mã nguồn
        */
        // for (int i = 0; i < 10; i++)
        // {

        // }
        // PrintThreeHelloWorld();
        /*
            mã nguồn
        */
        // int[] numbers = new int[10];
        // PrintThreeHelloWorld();

        // random.Next()
        // random.Next(max)
        // random.Next(min, max)
        // Math.Pow(6,7) => return 6^7;
        // Convert.ToInt32("10");
        // Console.Write("Hello") => viết lên terminal chữ Hello;

        // 1. Chức năng của phương thức
        // 2. xác định input(đầu vào)/parameter(s). Có hay không? nếu có thì bao nhiêu?
        // 3. xác định output(đầu ra)

        // Khi tạo 1 phương thức cần trả lời 4 câu hỏi sau:
        // 1. Phương thức này làm nhiệm vụ gì? (nhiệm vụ đơn)
        // 2. Tên Phương thức là gì? => có ý nghĩa/gợi nhớ (nhiệm vụ của phương thức) => thường bắt đầu bởi 1 hành động
        // 3. Phương thức này có tham số không? nếu có thì bao nhiêu tham số?
        // 4. Phương này có trả về dữ liệu không? nếu có thì trả về dữ liệu gì?

        // Sử dụng phương thức
        // viết 1 phương thức trả về kết quả của 10 cộng 20
        // Viết 1 phương thức nhận vào 2 số và trả về tổng của 2 số đó
        // Parameter (tham số) vs Argument (Đối số)
        // Console.Write("Enter number 1: ");
        // int n_1 = Convert.ToInt32(Console.ReadLine()); //100
        // Console.Write("Enter number 2: ");
        // int n_2 = Convert.ToInt32(Console.ReadLine()); // 300
        // int n_1 = 10;
        // int n_2 = 100;
        // int result = Sum(n_1, n_2); //10 + 100 = 110
        // Console.WriteLine($"{n_1} + {n_2} = {Sum(n_1, n_2)}");

        // int n_3 = 10;
        // int n_4 = 200;
        // int result_2 = Sum(n_3, n_4); //10 + 100 = 110
        // Console.WriteLine($"Tong cua {n_3} va {n_4} là: {Sum(n_3, n_4)}");

        // Tổng của 10 và 20 là: 30


        //Total();
        // Sum(30, 40);
        // Sum10Plus20();
        // Sum30Plus40();
        #endregion
        int[] numbers = CreateArray(20, 10, 200);
        PrintArray(numbers);
        
        PrintArray(CreateArray(100, 1000, 2000));

        // PrintArray(new int[10] { 1, 4, 5, 3, 4, 5, 3, 2, 8, 3 });
    }

    static int[] CreateArray(int n, int min, int max)
    {
        int[] arr = new int[n];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(min, max);
        }
        return arr;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    static void Total()
    {
        Console.Write("Enter n1: ");
        int number_1 = Convert.ToInt32(Console.ReadLine()); //100
        Console.Write("Enter n2: ");
        int number_2 = Convert.ToInt32(Console.ReadLine()); // 300
        int total = number_1 + number_2;
        Console.WriteLine($"{number_1} + {number_2} = {total}");
    }

    static void Sum10Plus20()
    {
        int number_1 = 10;
        int number_2 = 20;
        int total = number_1 + number_2;
        Console.WriteLine($"{number_1} + {number_2} = {total}");
    }

    static void Sum30Plus40()
    {
        int number_1 = 30;
        int number_2 = 40;
        int total = number_1 + number_2;
        Console.WriteLine($"{number_1} + {number_2} = {total}");
    }

    // static void Sum(int number_1, int number_2)
    // {
    //     int total = number_1 + number_2;
    //     // Console.WriteLine($"{number_1} + {number_2} = {total}");
    //     Console.WriteLine($"Tong cua {number_1} va {number_2} la: {total}");
    // }
    static int Sum(int number_1, int number_2)
    {
        int total = number_1 + number_2;
        return total;
    }


    static void PrintThreeHelloWorld()
    {
        Console.WriteLine("=============");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("=============");
    }
}
