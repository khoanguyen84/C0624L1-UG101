namespace Loops;
class NestedLoop
{
    static void Main(string[] args)
    {
        // Vẽ 1 hình chữ nhật 10 x 15 trên màn hình
        // row = 10
        // element = 15 sử dụng *
        // int rows = 10, elements = 10;
        // for (int row = 1; row <= rows; row++) //n
        // {
        //     Console.Write($"{row}\t"); //\t = tab = 1.27cm
        //     for (int element = 1; element <= elements; element++) //n
        //     {
        //         Console.ForegroundColor = ConsoleColor.Green;
        //         // if (row == 1 || row == rows || element == 1 || element == elements)
        //         if (row == rows || element == 1 || element == row)
        //         {
        //             Console.Write("*");
        //         }
        //         else
        //         {
        //             Console.Write(" ");
        //         }

        //     }
        //     Console.Write("\n"); //\t = new line 
        //     Console.ResetColor();
        // }
        // Giả sử dữ liệu đủ lớn
        // Big O = Độ phức tạp của thuật toán = chi phí để thực thi thuật toán => đơn vị thời gian
        // O(n^n) O(n^2)

        // row = 1 row = rows 10 element = 1 element = elements = 15
        // int number = -1;
        // do
        // {
        //     // Console.Clear();
        //     Console.Write("Enter number = ");
        //     // number = Convert.ToInt32(Console.ReadLine());
        //     int.TryParse(Console.ReadLine(), out number);
        //     Console.WriteLine($"--{number}--");
        //     //giống nhau convert string to number
        //     // Convert.ToInt32 string (chuỗi số) "243343" => ok
        //     // abc => error

        //     // int.TryParse string (chuỗi số) "243343" => ok
        //     // abc => 0
        // }
        // while(number < 2 || number > 9);

        // int number = 0;
        // Console.Write("Enter number = ");
        // int.TryParse(Console.ReadLine(), out number);
        // while (number < 2 || number > 9)
        // {
        //     Console.Write("Enter number = ");
        //     int.TryParse(Console.ReadLine(), out number);
        // }

        // int number = 0;
        // Console.Write("Enter number = ");
        // int.TryParse(Console.ReadLine(), out number);
        // for (; number < 2 || number > 9;)
        // {
        //     Console.Write("Enter number = ");
        //     int.TryParse(Console.ReadLine(), out number);
        // }

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 2; j <= 9; j++)
            {
                if (i * j > 9)
                {
                    if (i < 10)
                    {
                        Console.Write($"{j} x {i} = {i * j}   ");
                    }
                    else
                    {
                        Console.Write($"{j} x {i} = {i * j}  ");
                    }
                }
                else
                {
                    Console.Write($"{j} x {i} = {i * j}    ");
                }
            }
            Console.WriteLine();
        }
    }
}