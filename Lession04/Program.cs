using System;
using System.Text;
namespace Lession04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Console.WriteLine("Xin chào anh em");
            // Console.WriteLine("Lớp Game Unity");
            // Console.Write("Enter your name: ");
            // Console.ReadLine();
            //Khai báo biến => read/write
            // double age = 185;
            // int Age = 19;

            // string _fullname = "Quân Lê";
            //---
            // _fullname = "Khoa Nguyễn";
            // _fullname = "Chánh Trần";

            //khai báo hằng => readonly
            // const double pi = 3.14;  //const = constant


            //khai báo biến bằng từ khóa var = variable
            // var score = 8;
            // Console.WriteLine(score.GetType()); //GetType() => trả về kiểu dữ liệu


            // lưu trữ dữ liệu => xử lý dữ liệu => toán tử
            /*
                ctrl + / => comment/uncomment
                1. Toán tử số học/toán học: +, -, *, /, % => kết quả là một giá trị số
                2. Toán so sánh: >, >=, <, <=, ==  => kết quả là giá trị bool (true/false)
                3. Toán tử logic: && (and), || (or), ! (not) => kết hợp nhiều biểu thức logic => kết quả trả về giá trị bool
                4. Toán tử cộng chuỗi: + => kết quả trả về là 1 chuỗi
            */
            // int soDu = 10 % 4;
            // string firstname = "Khoa";
            // string lastname = "Nguyễn";
            // string fullname = firstname + " " + lastname;
            // string fullname = string.Format("{0} {1}", firstname, lastname);
            // string template
            // string fullname = $"{firstname} {lastname}";
            // string statement = $"{5 * 2} + {8 * 4} = {10 + 32}";
            // Console.WriteLine(statement);

            // Console.Write("Enter you age: ");
            // string age = Console.ReadLine();
            // Console.WriteLine($"You entered: {age}");
            // Console.Write("Enter number 1 = ");
            // int number_1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter number 2 = ");
            // int number_2 = int.Parse(Console.ReadLine());
            // Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");

            // Convert from datatype to datatype
        }
    }
}


