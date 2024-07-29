using System.Runtime.CompilerServices;

namespace ContactApp;

class PhoneBook : Phone
{
    private Contact[] phoneList = [];
    private readonly string path = @"D:\CGO\C0624L1-UG101\ContactApp\Data\";
    private readonly string fileName = "phonebook.txt";
    public PhoneBook()
    {
        FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.OpenOrCreate);
        string? line;
        using (StreamReader sr = new StreamReader(fs))
        {
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(" ");
                Array.Resize(ref phoneList, phoneList.Length + 1);
                Contact contact = new Contact(data[0], data[1]);
                phoneList[phoneList.Length - 1] = contact;
            }
        }
    }

    //InsertPhone("Trung", "119")
    public override void InsertPhone(string name, string phone)
    {
        int pos = -1; //not exist
        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].Name == name)
            {
                pos = i;
                break;
            }
        }
        if (pos == -1) // not exist
        {
            FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.Append);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine($"{name} {phone}");
                Array.Resize(ref phoneList, phoneList.Length + 1);
                Contact contact = new Contact(name, phone);
                phoneList[phoneList.Length - 1] = contact;
            }
        }
        else
        {
            phoneList[pos].PhoneNumber += $":{phone}";
            FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.Create);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                foreach(Contact contact in phoneList)
                {
                    sw.WriteLine($"{contact.Name} {contact.PhoneNumber}");
                }
            }
        }
    }
    public override void RemovePhone(string name)
    {
        throw new NotImplementedException();
    }

    public override void SearchPhone(string name)
    {
        #region search exactly
        // int pos = -1;
        // for (int i = 0; i < phoneList.Length; i++)
        // {
        //     if (phoneList[i].Name == name)
        //     {
        //         pos = i;
        //         break;
        //     }
        // }
        // Console.WriteLine("Search result");
        // if (pos == -1)
        // {
        //     Console.WriteLine("Not found");
        // }
        // else
        // {
        //     Console.WriteLine($"Name: {phoneList[pos].Name}, Phone: {phoneList[pos].PhoneNumber}");
        // }
        // Console.WriteLine("================================");
        #endregion

        bool notFound = true;
        Console.WriteLine("Search result");
        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].Name.Contains(name))
            {
                Console.WriteLine($"Name: {phoneList[i].Name}, Phone: {phoneList[i].PhoneNumber}");
                notFound = false;
            }
        }
        if (notFound)
        {
            Console.WriteLine("Not Found");
        }
        Console.WriteLine("================================");
    }

    public override void UpdatePhone(string name, string newPhone)
    {
        int pos = -1;
        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].Name == name)
            {
                pos = i;
                break;
            }
        }
        if (pos > -1)
        {
            phoneList[pos].PhoneNumber = newPhone;
        }
    }

    public override void Sort()
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.OpenOrCreate);
        string? line;
        using(StreamReader sr = new StreamReader(fs))
        {
            while((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(" ");
                Console.WriteLine($"Name: {data[0]}, Phone: {data[1]}");
            }
        }
        Console.WriteLine("================================");
    }
}