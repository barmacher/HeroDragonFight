using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Dragon
    {
        private string _name;

        public double Hp { get; set; }
        public double Armor { get; set; }
        public string Name
        {
            get
            {
                if (_name == "Smaug")
                {
                    return $"Hello {_name}";
                }
                else
                {
                    return _name;
                }
            }
            set
            {

            }
        }
        public double Damage { get; set; }
        public double Mana { get; set; }
        
        public Dragon(string name, double hp)
        {
            Name = name;
            Hp = hp;

        }

        public double Incinirate(Hero hero)
        {
            Console.WriteLine($"{Name} incinirate {hero.Name}");
            Random rand = new Random();
            double damage = rand.Next(100, 300);
            return damage;
        }

        public double TakeDamage(double damage)
        {
            Hp -= damage;
            Console.WriteLine($"Smaugs hp - {Hp}");

            return Hp;
        }

    }

    
}
