namespace Method;
class Out
{
    static void Main(string[] args)
    {
        /*
        Console.Write("Enter number = ");
        string value = Console.ReadLine(); //"10"               "abc"
        bool result = int.TryParse(value, out int number); // number = 10     0
        // nếu parse thành công => result = true
        // ngược lại            => result = false

        Console.WriteLine($"number = {number}");
        Console.WriteLine($"result = {result}");
        */

        int[] numbers = new int[7] { 4, 5, 7, 9, 10, 20, 24 };
        int value = 9;
        // int pos;
        // string result = FindValue(numbers, value, out int[] subNumbers);
        string result = FindValue(numbers, value, out int pos, out int found);
        Console.WriteLine($"Result = {result}");
        Console.WriteLine($"Position = {string.Join(", ", pos)}");
        Console.WriteLine($"Found value = {found}");
        // Console.WriteLine($"Position = {string.Join(", ", subNumbers)}");
    }
    /*
    static string FindValue(int[] numbers, int value, out int[] array)
    {
        array = new int[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == value)
            {
                return "Exist";
            }
            else
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = numbers[i];
            }
        }
        return "Not Exist";
    }
    */

    // kiểm tra xem value có trong mảng numbers
    // nếu có thì true không thì false
    static string FindValue(int[] numbers, int value, out int position, out int foundValue)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == value)
            {
                position = i;
                foundValue = numbers[i];
                return "Exist";
            }
        }
        position = -1;
        foundValue = -1;
        return "Not Exist";
    }
}