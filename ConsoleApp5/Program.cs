using ConsoleApp5;
 
try
{
    Console.WriteLine("Введите имя");
    string name = Console.ReadLine();
    Console.WriteLine("Введите хп");
    double hp = double.Parse(Console.ReadLine());
    Hero Vasya = new Hero(name, hp);
    if (name == "Vasya")
    {
        Console.WriteLine($"Имя - {name} и {hp}");
    }
    else
    {
        throw new Exception("Неверное имя");
    }

//Hero Vasya = new Hero("Vasya", 100);
Dragon Smaug = new Dragon("Smaug", 500);
double firstAttack = Vasya.Bite(Smaug);
Smaug.TakeDamage(firstAttack);
Console.WriteLine("Smaug breathes fire...");
double secondAttack = Smaug.Incinirate(Vasya);
Vasya.TakeDamage(secondAttack);
Vasya.Heal();
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка:" + ex.Message);
}
