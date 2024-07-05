using System.Collections.ObjectModel;
using System.Text;
namespace ArrayDemo;

class NestedArray
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region example nested array
        // int number_1 = 10;
        // int number_2 = 20;
        // int number_3 = 30;
        // int number_4 = 40;

        // int[] numbers = new int[4]
        // {
        //     10,
        //     20,
        //     30,
        //     40
        // };

        // string[] team_1 = new string[3] { "Luân", "Duy", "Nhi" };
        // string[] team_2 = new string[3] { "Chánh", "Huy", "Tấn" };
        // string[] team_3 = new string[3] { "Quân", "Trung", "Anh" };
        // string[] team_4 = new string[4] { "Thịnh", "Duy", "Điền", "Bảo" };
        #endregion

        string[][] class_gu_101 = new string[4][]
        {
            new string[3] { "Luân", "Duy", "Nhi" },
            new string[3] { "Chánh", "Huy", "Tấn" },
            new string[3] { "Quân", "Trung", "Anh" },
            new string[4] { "Thịnh", "Duy", "Điền", "Bảo"}
        };

        for (int team = 0; team < class_gu_101.Length; team++)
        {
            // Console.WriteLine($"team {team} - members: {string.Join(" - ", class_gu_101[team])}");
            for (int men = 0; men < class_gu_101[team].Length; men++)
            {
                // Console.WriteLine($"team {team} - count: {class_gu_101[team].Length}");
                Console.Write($"{class_gu_101[team][men]}\t");
            }
            Console.WriteLine();
        }
    }
}