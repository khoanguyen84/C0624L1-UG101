namespace OOP;
class Staff
{
    /// <summary>
    /// Properties
    /// </summary>
    public string Fullname { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; }
    private string mobile;

    public string Mobile
    {
        set => mobile = value;
        get => $"{mobile.Substring(0, mobile.Length - 3)}XXX";
    }

    //0935216417


    /// <summary>
    /// fields (trường)
    /// </summary>
    private DateTime _dob = new DateTime();

    public string GetDob()
    {
        return this._dob.ToShortDateString();
    }

    public void SetDob(DateTime dob)
    {
        this._dob = dob;
    }

    public Staff()
    {
        this._dob = new DateTime();
        Console.WriteLine("Execute Constructor without parameter");
    }
    public Staff(string fullname)
    {
        Fullname = fullname;
        Console.WriteLine("Execute Constructor 1 parameter");
    }
    public Staff(string fullname, int age)
    {
        Fullname = fullname;
        Age = age;
        Console.WriteLine("Execute Constructor 2 parameters");

        // ShowDob();
    }

    private void ShowDob()
    {
        this._dob = new DateTime();
        Console.WriteLine(this._dob);
    }
}