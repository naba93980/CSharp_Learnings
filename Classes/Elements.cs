namespace Classes;

public class Elements
{
    public List<string> orders = new List<string>();    // initialize like this when u dont need to pass values from outside
    readonly public List<int> rolls = new List<int>();  // readonly field can be asigned only once

    Elements(List<int> rolls)
    {
        this.rolls = rolls;     //  // initialize like this when u  need to pass values from outside
    }
}
