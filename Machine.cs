namespace Coffee;
// Американо; Капучино; Латте; Мокко; Раф
public class Machine
{
    private string[] types { get; } = new string[]{"Американо", "Капучино", "Латте", "Мокко", "Раф"};
    private int choosedCoffee = default;
    
    public void getOrder()
    {
        Console.Write("Какой кофе желаете сегодня? Просто нажмите на кнопку! - ");
        int choosedCoffee = checkNchoice();
        Console.WriteLine("Ожидайте, через секунду будет готово...");
        Console.WriteLine("..");
        Console.WriteLine($"Вот ваш {types[choosedCoffee]}, наслаждайтесь)");
    }
    
    public void printTypes()
    {
        for (int i = 0; i < types.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {types[i]}");
        }
    }

    private int checkNchoice()
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
                Console.Write("Выберите кофе, ПОЖАЛУЙСТА - ");
            }
        }

        choice--;
        return choice;
    }
    
        
}