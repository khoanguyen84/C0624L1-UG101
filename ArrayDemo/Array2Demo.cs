namespace ArrayDemo;
class Array2Demo
{
    static void Main(string[] args)
    {
        // double[,] scores = new double[rows, columns];
        // double[,] scores = new double[3, 5];
        // double[, ,] scores = new double[1, 1, 1]
        // {
        //     {
        //         { 
        //             10
        //         }
        //     }
        // };

        // double[,] scores = new double[3, 5]
        // {
        //     {2, 3, 4, 5, 6},
        //     {2, 3, 4, 5, 6},
        //     {2, 3, 4, 5, 6}
        // };
        // // Console.WriteLine($"rows = {scores.GetLength(0)}");
        // // Console.WriteLine($"cols = {scores.GetLength(1)}");
        // for (int row = 0; row < scores.GetLength(0); row++)
        // {
        //     for (int col = 0; col < scores.GetLength(1); col++)
        //     {
        //         Console.Write($"{scores[row, col]}\t");
        //     }
        //     Console.WriteLine();
        // }

        // Tạo ra một matrix 5x7 với các giá trong matrix được sinh ngẫu nhiên [10, 90]
        int[,] matrix = new int[5, 7];
        // {
        //     { 71, 85, 55, 83, 58, 35, 15 },
        //     { 63, 63, 69, 80, 77, 33, 59 },
        //     { 89, 31, 17, 19, 29, 62, 17 },
        //     { 89, 47, 14, 48, 39, 72, 71 },
        //     { 79, 70, 73, 53, 50, 17, 32 }
        // };
        Random random = new Random();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = random.Next();
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }

    }
}