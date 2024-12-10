using Coffee;

Machine newUser = new Machine();

Console.WriteLine("Добро пожаловать к нашей кофемашине! У нас самый лучший вкус и аромат в этом репозитории!");
Console.WriteLine("Вот наше сегодняшнее меню:");

newUser.printTypes();
newUser.getOrder();

Console.WriteLine("Хорошего дня!");