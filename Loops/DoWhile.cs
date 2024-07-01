namespace Loops;
class DoWhile
{
    static void Main(string[] args)
    {
        // for (byte start = 110; start < 109; start += 1)
        // {
        //     Console.WriteLine("Hello everyone!");
        // }

        // byte start = 110;
        // while (start < 109)
        // {
        //     Console.WriteLine("Hello everyone!");
        //     start++;
        // }

        byte start = 100;
        do
        {
            Console.WriteLine("Hello everyone!");
            start++;
        }
        while(start <= 109);
        // thực thi ít nhất 1 lần
    }
}