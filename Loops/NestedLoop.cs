namespace Loops;
class NestedLoop
{
    static void Main(string[] args)
    {
        // Vẽ 1 hình chữ nhật 10 x 15 trên màn hình
        // row = 10
        // element = 15 sử dụng *
        int rows = 10, elements = 15;
        for (int row = 1; row <= rows; row++) //n
        {
            Console.Write($"{row}\t"); //\t = tab = 1.27cm
            for (int element = 1; element <= elements; element++) //n
            {
                Console.Write("*");
            }
            Console.Write("\n"); //\t = new line 
        }
        // Giả sử dữ liệu đủ lớn
        // Big O = Độ phức tạp của thuật toán = chi phí để thực thi thuật toán => đơn vị thời gian
        // O(n^n) O(n^2)
    }
}