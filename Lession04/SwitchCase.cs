namespace Lession04;
class SwitchCase
{
    // Naming Convention 
    // hovaten tonghaiso
    /*
        F1: PascalCase => HoVaTen TongHaiSo => namspace, class, method
        F2: camelCase => hoVaTen tongHaiSo => varible
        F3: snake_case => ho_va_ten tong_hai_so
    */
    // CÓ 2 loại lỗi
    // 1. Syntax error
    // 2. Logic error
    static void Main(string[] args)
    {
        // Console.Write("Enter month: ");
        // int month = Convert.ToInt32(Console.ReadLine());
        int month = 4;
        #region Switch Case not clearn code
        // switch(month)
        // {
        //     case 1: 
        //         Console.Write("31 days");
        //         break;
        //     case 2: 
        //         Console.Write("28 or 29 days");
        //         break;
        //     case 3: 
        //         Console.Write("31 days");
        //         break;
        //     case 4: 
        //         Console.Write("30 days");
        //         break;
        //     case 5: 
        //         Console.Write("31 days");
        //         break;
        //     case 6: 
        //         Console.Write("30 days");
        //         break;
        //     case 7: 
        //         Console.Write("31 days");
        //         break;
        //     case 8: 
        //         Console.Write("31 days");
        //         break;
        //     case 9: 
        //         Console.Write("30 days");
        //         break;
        //     case 10: 
        //         Console.Write("31 days");
        //         break;
        //     case 11: 
        //         Console.Write("30 days");
        //         break;
        //     case 12: 
        //         Console.Write("31 days");
        //         break;
        //     default: 
        //         Console.WriteLine("You entered invalid month");
        //         Console.WriteLine("Please enter from 1 to 12");
        //         break;
        // }
        #endregion

        switch(month)
        {
            case 1:
            case 3:
            case 4:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.Write("31 days");
                break;
            case 2: 
                Console.Write("28 or 29 days");
                break;
            case 5: 
            case 6:
            case 9:
            case 11:
                Console.Write("30 days");
                break;
            default: 
                Console.WriteLine("You entered invalid month");
                Console.WriteLine("Please enter from 1 to 12");
                break;
        }

    }
}
