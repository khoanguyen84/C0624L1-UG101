namespace Inheritance;
class Course
{
    public static int Length { get; set; }
    public static string Title { get; set; }
    public static string Unit = "CodeGym Huế";

    public static string Info()
    {
        return $"{Title}, {Length}";
    }
}