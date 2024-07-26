namespace ContactApp;

class PhoneBook : Phone
{
    public Contact[] PhoneList = new Contact[2]
    {
        new Contact("Duy", "113"),
        new Contact("Dien", "114"),
    };

    //InsertPhone("Trung", "119")
    public override void InsertPhone(string name, string phone)
    {
        int pos = -1; //not exist
        for (int i = 0; i < PhoneList.Length; i++)
        {
            if (PhoneList[i].Name == name)
            {
                pos = i;
                break;
            }
        }
        if (pos == -1) // not exist
        {
            Array.Resize(ref PhoneList, PhoneList.Length + 1);
            Contact contact = new Contact(name, phone);
            PhoneList[2] = contact;
        }
        else
        {
            PhoneList[pos].PhoneNumber += $":{phone}";
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
        // for (int i = 0; i < PhoneList.Length; i++)
        // {
        //     if (PhoneList[i].Name == name)
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
        //     Console.WriteLine($"Name: {PhoneList[pos].Name}, Phone: {PhoneList[pos].PhoneNumber}");
        // }
        // Console.WriteLine("================================");
        #endregion

        bool notFound = true;
        Console.WriteLine("Search result");
        for (int i = 0; i < PhoneList.Length; i++)
        {
            if (PhoneList[i].Name.Contains(name))
            {
                Console.WriteLine($"Name: {PhoneList[i].Name}, Phone: {PhoneList[i].PhoneNumber}");
                notFound = false;
            }
        }
        if(notFound)
        {
            Console.WriteLine("Not Found");
        }
        Console.WriteLine("================================");
    }

    public override void UpdatePhone(string name, string newPhone)
    {
        int pos = -1;
        for (int i = 0; i < PhoneList.Length; i++)
        {
            if (PhoneList[i].Name == name)
            {
                pos = i;
                break;
            }
        }
        if (pos > -1)
        {
            PhoneList[pos].PhoneNumber = newPhone;
        }
    }

    public override void Sort()
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        for (int i = 0; i < PhoneList.Length; i++)
        {
            Console.WriteLine($"Name: {PhoneList[i].Name}, Phone: {PhoneList[i].PhoneNumber}");
        }
        Console.WriteLine("================================");
    }
}