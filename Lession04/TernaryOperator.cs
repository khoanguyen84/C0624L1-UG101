namespace Lession04;
class TernaryOperator
{
    static void Main(string[] args)
    {
        // bool gender = true;
        // bool married = true;
        // string firstName = "Khoa";
        // gender = false => Ms. Bình
        // gender = true => Mr. Bình
        // gender = false => married = false => Ms. Bình
        // gender = false => married = true => Mrs. Bình
        // if(gender) 
        // {
        //     Console.Write($"Mr. {firstName}");
        // }
        // else 
        // {
        //     if(married)
        //     {
        //         Console.Write($"Mrs. {firstName}");
        //     }
        //     else 
        //     {
        //         Console.Write($"Ms. {firstName}");
        //     }
        // }
        // ? : = ternary operator
        // string result = gender ? $"Mr. {firstName}": 
        //                     married ? $"Mrs. {firstName}" : $"Ms. {firstName}";
        // Console.Write(result);

        // Console.Write(gender ? $"Mr. {firstName}": 
        //                     married ? $"Mrs. {firstName}" : $"Ms. {firstName}");

        // Console.Write($"{(gender ? "Mr" : married ? "Mrs": "Ms")}. {firstName}");
        int number_1 = 5;
        int number_2 = 10;
        int number_3 = 7;
        int max = number_1 > number_2 && number_1 > number_3 ? number_1 : 
                                    number_2 > number_1 && number_2 > number_3 ? number_2 : number_3;   
        Console.Write($"max = {max}");
    }
}