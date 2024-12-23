namespace Coffee.Coffees;

public class Mocco : BlackCoffee
{
    public Mocco(bool hot, int sugar)
    {
        isHot = hot;
        sugarCount = sugar;
        Make();
        Console.WriteLine($"Вот ваш {AddedHot()}мокко с {sugarCount} of сахарный кубик");
    }

    public void Make()
    {
        Console.WriteLine("Заполняем горячим шоколадом..");
        Console.WriteLine("Наливаем Эспрессо..");
        Console.WriteLine("Добавляем молоко..");
        Console.WriteLine("Накидываем взбитые сливки...");
    }
}