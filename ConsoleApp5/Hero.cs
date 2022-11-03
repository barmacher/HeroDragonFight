using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Hero
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Mana { get; set; }
        public List<Weapon> Inventory { get; set; }
        public List<Armor> Armor { get; set; }

        
  
        public Hero(string name, double hp)

        {
            Name = name;
            Hp = hp;
            
        }



        public double Bite(Dragon dragon)
        {
            Console.WriteLine($"{Name} bites {dragon.Name}");
            Random rand = new Random();
            double damage = rand.Next(5, 10);
            Console.WriteLine($"{Name} has taken {damage}");
            return damage;
        }

        public double TakeDamage(double damage)
        {
            if (damage >= Hp)
            {
                Console.WriteLine($"{Name} dies, ugh!");
            }
            else
            {
                Hp -= damage;
                Console.WriteLine($"{Name} HP is {Hp}");
            }
            return Hp;
        }

        public void Heal()
        {
           
            Random rand = new Random();
            int giveheal = rand.Next(30, 100);
            if (Hp < 10)
            {
                Hp += giveheal;
                Console.WriteLine($"Вася восполнил {giveheal} хп, нынешнее здоровье {Name} : {Hp}");
            }
            else
            {
                Console.WriteLine($"Здоровье {Name} : {Hp}");
            }
        }
    }
}
