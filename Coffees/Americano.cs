namespace Coffee.Coffees;

public class Americano : BlackCoffee
{
    public Americano(bool hot, int sugar)
    {
        isHot = hot;
        sugarCount = sugar;
        Make();
        Console.WriteLine($"Вот ваш {AddedHot()}американо с {sugarCount} of сахарный кубик");
    }

    public void Make()
    {
        Console.WriteLine("Наливаем Эспрессо..");
        Console.WriteLine("Добавляем воду...");
    }
}
