namespace Coffee.Coffees;

public class Raph : BlackCoffee
{
    public Raph(bool hot, int sugar)
    {
        isHot = hot;
        sugarCount = sugar;
        Make();
        Console.WriteLine($"Вот ваш {AddedHot()}раф с {sugarCount} of сахарный кубик");
    }

    public void Make()
    {
        Console.WriteLine("Заполняем сиропом..");
        Console.WriteLine("Наливаем Эспрессо..");
        Console.WriteLine("Накидываем взбитое молоко..");
    }
}