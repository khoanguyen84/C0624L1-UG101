namespace Method;
class Calculator
{
    static int PLUS = 1;
    static void Main(string[] args)
    {
        do
        {
            Menu(out int selector);
            Process(selector);
        }
        while (true);
    }

    static void Menu(out int selector)
    {
        int choice = 0;
        do
        {
            if (choice > 4 || choice < 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alert: you entered invalid key");
                Console.ResetColor();
            }
            Console.WriteLine("========= MENU =========");
            Console.WriteLine("Press 1 to plus");
            Console.WriteLine("Press 2 to minus");
            Console.WriteLine("Press 3 to multiply");
            Console.WriteLine("Press 4 to division");
            Console.WriteLine("Press 0 to quit");
            Console.WriteLine("========================");
            Console.Write("Enter your choice = ");
            int.TryParse(Console.ReadLine(), out choice);
        }
        while (choice > 4 || choice < 0);
        selector = choice;
    }

    static void Process(int selector)
    {

        switch (selector)
        {
            case 1:
                Console.Clear();
                Operator(selector);
                break;
            case 2:
                Console.Clear();

                break;
            case 3:
                Console.Clear();
                Console.WriteLine("You select multiply");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("You select division");
                break;
            case 0:
                Environment.Exit(0);
                break;
        }
    }

    static void PlusOperator()
    {
        Console.Write("Enter number 1 = ");
        int.TryParse(Console.ReadLine(), out int number_1);
        Console.Write("Enter number 2 = ");
        int.TryParse(Console.ReadLine(), out int number_2);
        Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");
    }
    static void MinusOperator()
    {
        Console.Write("Enter number 1 = ");
        int.TryParse(Console.ReadLine(), out int number_1);
        Console.Write("Enter number 2 = ");
        int.TryParse(Console.ReadLine(), out int number_2);
        Console.WriteLine($"{number_1} - {number_2} = {number_1 - number_2}");
    }
    static void MultiplyOperator()
    {
        Console.Write("Enter number 1 = ");
        int.TryParse(Console.ReadLine(), out int number_1);
        Console.Write("Enter number 2 = ");
        int.TryParse(Console.ReadLine(), out int number_2);
        Console.WriteLine($"{number_1} x {number_2} = {number_1 * number_2}");
    }

    static void Operator(int sign)
    {
        Console.Write("Enter number 1 = ");
        int.TryParse(Console.ReadLine(), out int number_1);
        Console.Write("Enter number 2 = ");
        int.TryParse(Console.ReadLine(), out int number_2);
        if(sign == PLUS)
            Console.WriteLine($"{number_1} x {number_2} = {number_1 * number_2}");
    }
}