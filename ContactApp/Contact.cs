namespace ContactApp;
class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Contact(string _name, string _phoneNumber)
    {
        Name = _name;
        PhoneNumber = _phoneNumber;
    }
}