namespace Exception;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers = new int[5] { 4, 7, 3, 8, 6 };
        // Console.WriteLine(numbers[5]);
        // Console.Write("Enter number = ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter divisor = ");
        // int divisor = Convert.ToInt32(Console.ReadLine());
        // if (divisor != 0)
        // {
        //     Console.WriteLine(number / divisor);
        // }
        // else
        // {
        //     Console.WriteLine("Divide by zero");
        // }

        try
        {
            Console.Write("Enter number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter divisor = ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number / divisor);
        }
        catch(System.DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero!");
        }
        catch(System.FormatException ex)
        {
            Console.WriteLine("Input value is invalid");
        }
        catch(System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("DONE");
        }
    }
}
