namespace ContactApp;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // PhoneBook phoneBook = new PhoneBook();
        // phoneBook.Display();
        // phoneBook.InsertPhone("Dien", "115");
        // phoneBook.Display();
        // string str_1 = "Khoa";
        // string str_2 = "Bình";
        // Console.WriteLine(string.Compare(str_1, str_2, true));
        // str_1 > str_2 => str_1 - str_2 > 0
        // str_1 = str_2 => str_1 - str_2 = 0
        // str_1 < str_2 => str_1 - str_2 < 0

        string[] nameList = new string[8] { "Luân", "Huy", "Tan", "Quan", "Thinh", "Dien", "chanh", "Duy" };
        for (int i = 0; i < nameList.Length - 1; i++)
        {
            for (int j = i + 1; j < nameList.Length; j++)
            {
                if(string.Compare(nameList[i], nameList[j], false) > 0)
                {
                    string temp = nameList[i];
                    nameList[i] = nameList[j];
                    nameList[j] = temp;
                }
            }
        }


        Console.WriteLine(string.Join(", ", nameList));
    }
}
