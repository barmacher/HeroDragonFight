using ConsoleApp5;
Hero Vasya = new Hero("Vasya", 100);
Dragon Smaug = new Dragon("Smaug", 500);
double firstAttack = Vasya.Bite(Smaug);
Smaug.TakeDamage(firstAttack);
Console.WriteLine("Smaug breathes fire...");
double secondAttack = Smaug.Incinirate(Vasya);
Vasya.TakeDamage(secondAttack);