namespace Coffee.Coffees;

public class Capucino : BlackCoffee
{
    public Capucino(bool hot, int sugar)
    {
        isHot = hot;
        sugarCount = sugar;
        Make();
        Console.WriteLine($"Вот ваш {AddedHot()}капучино с {sugarCount} of сахарный кубик");
    }

    public void Make()
    {
        Console.WriteLine("Наливаем Эспрессо..");
        Console.WriteLine("Добавляем молоко..");
        Console.WriteLine("Накидываем взбитое молоко...");
    }
}