using System;
namespace mermaid_dragon_unicorn.models
{
    public class Creature
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int  Happiness;
        private int health;
        public int Health
        {
            get{return health;}

        }
        public void SetHealth(int hp)
        {
            health = hp;
        }

        public Creature(string name, int strength = 3, int intelligence = 3, int happiness = 3, int hp = 100)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Happiness = happiness;
            health = hp;
        }
        public virtual int Attack(Creature target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Here are {Name}'s stats:");
            Console.WriteLine($"{Strength} Strength");
            Console.WriteLine($"{Intelligence} Intelligence");
            Console.WriteLine($"{Happiness} Happiness");
            Console.WriteLine($"{health} Health");


        }

        
    }
}