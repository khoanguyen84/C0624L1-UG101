namespace ArrayDemo;

class Program
{
    static void Main(string[] args)
    {
        #region Create Array 01
        // Cách 1: tạo mảng và ko gán giá trị (sử dụng giá trị mặc định)
        // phải xác định trước số phần tử => khi tạo mảng
        // giá trị mặc định => phụ thuộc vào kiểu dữ liệu của mảng


        // int[] numberList = new int[5]; //index = [0, 4]
        // Console.WriteLine($"0 - {numberList[0]}");
        // Console.WriteLine($"4 - {numberList[4]}");

        // string[] jobList = new string[3];
        // Console.WriteLine($"0 - {jobList[0]}");
        // Console.WriteLine($"2 - {jobList[2]}");

        // double[] scoreList = new double[5];
        // Console.WriteLine($"1 - {scoreList[1]}");
        // Console.WriteLine($"4 - {scoreList[4]}");

        // bool[] genderList = new bool[5];
        // Console.WriteLine($"0 - {genderList[0]}");
        // Console.WriteLine($"1 - {genderList[1]}");
        // Console.WriteLine($"2 - {genderList[2]}");
        // Console.WriteLine($"3 - {genderList[3]}");
        // Console.WriteLine($"4 - {genderList[4]}");
        #endregion

        #region Create Aray 02
        // Tạo mảng và gán luôn giá trị ban đầu
        // cách 1:
        // int[] numberList = { 10, 30, 50, 70, 80 };
        // for(int index = 0; index < numberList.Length; index++)
        // {
        //     Console.WriteLine($"{index} - {numberList[index]}");
        // }

        // cách 2
        // int[] numberList = new int[4] { 10, 30, 50, 70 };
        // for (int index = 0; index < numberList.Length; index++)
        // {
        //     Console.WriteLine($"{index} - {numberList[index]}");
        // }
        // // out, ref => function
        // Array.Resize(ref numberList, 10);
        // Console.WriteLine(numberList.Length);

        #endregion

        // int number = 10;
        // Console.WriteLine(number++);
        // Console.WriteLine($"2-{number}");
        // 1. in number ra màn hình
        // 2. tăng number lên 1 đơn vị (bước cuối cùng)
        // 1 => 2
        // Console.WriteLine(++number);
        // Console.WriteLine($"2-{number}");
        // 1. in number ra màn hình
        // 2. tăng number lên 1 đơn vị (bước đầu tiên)
        // 2 => 1

        int i = 1;
        int[] numberList = new int[1];
        int number = 0;
        // while (true)
        // {
        //     Console.Write($"NumberList[{i - 1}] = ");
        //     numberList[i - 1] = Convert.ToInt32(Console.ReadLine());
        //     if (numberList[i - 1] == 0)
        //         break;
        //     Array.Resize(ref numberList, ++i);
        // }
        do
        {
            Console.Write($"NumberList[{i - 1}] = ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numberList[i - 1] = number;
                Array.Resize(ref numberList, ++i);
            }
            else
            {
                Array.Resize(ref numberList, numberList.Length - 1);
            }
            Console.WriteLine(numberList.Length);
        }
        while (number != 0);

        Console.WriteLine(string.Join(" - ", numberList));
    }
}
