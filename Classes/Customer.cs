namespace Classes;

public class Customer
{
    public string name;
    readonly public int id;

    public Customer(int id)
    {
        this.id=id;
    }

    public Customer(string name,int  id) : this(id)
    {
        this.name=name;
    }
}
