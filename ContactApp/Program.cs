namespace ContactApp;

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Display();
        phoneBook.InsertPhone("Trung", "119");
        phoneBook.Display();
        phoneBook.SearchPhone("m");
        // phoneBook.UpdatePhone("Dien", "911");
        // phoneBook.Display();
        // phoneBook.InsertPhone("Dien", "911");
        // phoneBook.Display();
    }
}
