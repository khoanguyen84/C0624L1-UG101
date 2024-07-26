namespace ContactApp;

class PhoneBookBK : Phone
{
    public string[][] PhoneList = new string[2][]
    {
        new string[] { "Duy", "113"},
        new string[] { "Điền", "114"},
    };

    //InsertPhone("Trung", "119")
    public override void InsertPhone(string name, string phone)
    {
        //               length = 2
        Array.Resize(ref PhoneList, PhoneList.Length + 1);
        //               length = 3
        string[] contact = new string[] { name, phone };
        // => ["Trung", "119"]
        PhoneList[PhoneList.Length - 1] = contact;

    }
    public override void RemovePhone(string name)
    {
        throw new NotImplementedException();
    }

    public override void SearchPhone(string name)
    {

        throw new NotImplementedException();
    }

    public override void UpdatePhone(string name, string newPhone)
    {
        throw new NotImplementedException();
    }

    public override void Sort()
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        for(int i = 0; i < PhoneList.Length; i++)
        {
            Console.WriteLine($"Name: {PhoneList[i][0]}, Phone: {PhoneList[i][1]}");
        }
        Console.WriteLine("================================");
    }
}