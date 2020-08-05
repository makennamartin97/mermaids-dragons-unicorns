using System;
namespace mermaid_dragon_unicorn.models
{
    class Unicorn : Creature
    {
        public Unicorn(string name): base(name)
        {
            Name = name;
            Happiness = 175;
        }
        public override int Attack(Creature target)
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            int dmg;
            if(chance < 20)
            {
                dmg = 5 * target.Happiness + 10;

            }
            else{
                dmg = 5 * target.Happiness;

            }
            
            target.Happiness -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} happiness, now they have {target.Happiness}");
            return target.Happiness;
        }
        public int Steal(Creature target)
        {
            target.SetHealth(target.Health - 5);
            SetHealth(Health + 5);
            Console.WriteLine($"{Name} stole 5 hp from {target.Name} ");
            return Health;

        }
    }
}