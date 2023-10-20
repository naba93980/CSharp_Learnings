namespace Classes;

public class Property
{
    private string? _name;
    public string Name
    {
        get { return _name + " Modak"; }
        set { _name = value; }
    }
    public int Id { get; set; }     // automatically creates private fields
    public int Age { get; private set; } // setter cannot be accessed from outside the class, only getter can be accessed



    public Property(int age)
    {
        Age = age;
    }
}

// property - A class member that encapsulates a getter/setter for accessing a field