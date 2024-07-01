namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        #region 
        /*
            b1: số lần lặp = 10
            b2: tại mỗi lần lặp => làm cái gì
            b2: bắt đầu từ đâu? (optional)
        */
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        // Console.WriteLine("Hello everyone!");
        #endregion

        // for (byte start = 100; start < 109; start += 2)
        // {
        //     Console.WriteLine("Hello everyone!");
        // }

        // for(byte end = 105; end > 100; end--)
        // {
        //     Console.WriteLine("How are you tonight");
        // }
        // int number = 10;
        // number = number + 5;
        // number += 5; //~ number = number + 5
        // number = number + 1;
        // number += 1;
        // number++; // ~ number += 1;

        // Console.Write("Enter number = ");
        // int number = Convert.ToInt32(Console.ReadLine()); //10
        // int number = 10;
        // bool isPrimer = true;
        // for (int i = 2; i < number; i++)  // i = [2, 9] 
        // {
        //     if (number % i == 0)
        //     {
        //         isPrimer = false;
        //         break;
        //     }
        // }

        // if (number < 2 || !isPrimer)
        //     Console.WriteLine($"{number} is not primer");
        // else
        //     Console.WriteLine($"{number} is primer");
        // isPrimer == true ? Console.WriteLine($"{number} is primer") : Console.WriteLine($"{number} is not primer");

        // string result = isPrimer == true ? $"{number} is primer" : $"{number} is not primer";
        // Console.WriteLine(result);

        // Console.WriteLine(isPrimer == true ? $"{number} is primer" : $"{number} is not primer");

        for (int i = 100, count = 1; i <= 400 && count <= 5; i += 5, count++)
        {
            Console.Write($"{i} ");
        }
    }
}

// 100 {1, 2, 4, 8, 16} => 100000 lần
// [2, 15] => { 2, 4, 8} => 99998 lần
// [2, căn bậc 2 của 16] => [2, 4] => 100 lần
