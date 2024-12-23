namespace Coffee.Coffees;

public class Latte : BlackCoffee
{
    public Latte(bool hot, int sugar)
    {
        isHot = hot;
        sugarCount = sugar;
        Make();
        Console.WriteLine($"Вот ваш {AddedHot()}латте с {sugarCount} of сахарный кубик");
    }

    public void Make()
    {
        Console.WriteLine("Наливаем Эспрессо..");
        Console.WriteLine("Добавляем молоко..");
        Console.WriteLine("Накидываем взбитые сливки...");
    }
}