namespace Coffee.Coffees;

public class BlackCoffee
{
    public bool isHot { get; set; } = default;
    public int sugarCount { get; set; } = default;
    
    public string AddedHot()
    {
        string word = null;
        if (isHot) word = "горячий ";
        return word;
    }
}