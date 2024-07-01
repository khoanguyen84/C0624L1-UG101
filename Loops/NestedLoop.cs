namespace Loops;
class NestedLoop
{
    static void Main(string[] args)
    {
        // Vẽ 1 hình chữ nhật 10 x 15 trên màn hình
        // row = 10
        // element = 15 sử dụng *
        int rows = 10, elements = 15;
        for (int row = 1; row <= rows; row++)
        {
            Console.Write($"{row}\t"); //\t = tab = 1.27cm
            for (int element = 1; element <= elements; element++)
            {
                Console.Write("*");
            }
            Console.Write("\n"); //\t = new line 
        }
    }
}