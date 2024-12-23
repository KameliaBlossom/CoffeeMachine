using System.Security.Cryptography;

namespace Coffee;
using Coffees;
// Американо; Капучино; Латте; Мокко; Раф
public class Machine
{
    private string[] types { get; } = new string[]{"Американо", "Капучино", "Латте", "Мокко", "Раф"};
    private int choosedCoffee = default;
    private int sugar = default;
    private bool hotCoffee = default;

    public Machine()
    {
        BlackCoffee cup;
        PrintTypes();
        GetOrder();
        Console.Write("Сколько кубиков сахара добавить? 5 максимум - ");
        sugar = CheckNchoice();
        Console.Write("А кофе горячий? Y/N ");
        switch (Console.ReadLine())
        {
            case "Y":
                hotCoffee = true;
                break;
            case "N":
                hotCoffee = false;
                break;
            default:
                Console.WriteLine("Значит горячий..");
                hotCoffee = true;
                break;
        }
        
        switch (choosedCoffee)
        {
            case 1:
                cup = new Americano(hotCoffee, sugar);
                break;
            case 2:
                cup = new Mocco(hotCoffee, sugar);
                break;
            case 3:
                cup = new Raph(hotCoffee, sugar);
                break;
            case 4:
                cup = new Latte(hotCoffee, sugar);
                break;
            case 5:
                cup = new Capucino(hotCoffee, sugar);
                break;
        }
    }
    public void GetOrder()
    {
        Console.Write("Сделайте заказ(введите число) - ");
        choosedCoffee = CheckNchoice();
    }
    
    public void PrintTypes()
    {
        for (int i = 0; i < types.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {types[i]}");
        }
    }

    private int CheckNchoice()
    {
        bool correctFlag = false;
        string input;
        int choice = default;

        while (correctFlag == false)
        {
            input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 5)
            {
                correctFlag = true;
            }
            else
            {
                Console.Write("Выберите кнопку, ПОЖАЛУЙСТА - ");
            }
        }
        
        return choice;
    }
    
        
}