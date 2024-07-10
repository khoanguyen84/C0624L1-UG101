namespace Method;
class Ref
{
    // Ref = reference (tham chiếu)
    static void Main(string[] arg)
    {

        int number_1 = 10;
        int number_2 = 20;
        Console.WriteLine($"1. Number 1: {number_1}, Number 2: {number_2}"); //1. 10 - 20
        Swap(ref number_1, ref number_2);
        Console.WriteLine($"3. Number 1: {number_1}, Number 2: {number_2}"); //3. 10 - 20 || 20 - 10

        /*
            bước 1: temp
            bước 2: temp = number_1 = 10
            bước 3: number_1 = number_2 = 20
            bước 4: number_2 = temp = 10
        */
        /*
        string[] jobList_1 = new string[3] { "Java", ".NET", "ReactJS" };
        string[] jobList_2 = jobList_1;
        Console.WriteLine($"1. JobList 1: {string.Join("-", jobList_1)}"); // Java-.NET-ReactJS
        Console.WriteLine($"1. JobList 2: {string.Join("-", jobList_2)}"); // Java-.NET-ReactJS
        jobList_2[1] = "PHP";
        Console.WriteLine($"2. JobList 1: {string.Join("-", jobList_1)}"); // Java-PHP-ReactJS
        Console.WriteLine($"2. JobList 2: {string.Join("-", jobList_2)}"); // Java-PHP-ReactJS

        int number_1 = 100;
        int number_2 = number_1; //number_2 được gán giá trị của number_1
        Console.WriteLine($"1. Number 1: {number_1}"); // 100
        Console.WriteLine($"1. Number 2: {number_2}"); // 100
        number_2 = 300;
        Console.WriteLine($"2. Number 1: {number_1}"); // 100
        Console.WriteLine($"2. Number 2: {number_2}"); // 300
        */
    }

    static void Swap(ref int number_1, ref int number_2)
    {
        int temp = number_1;
        number_1 = number_2;
        number_2 = temp;
        Console.WriteLine($"2. Number 1: {number_1}, Number 2: {number_2}"); //2. 20 - 10
    }
}