using System;
namespace mermaid_dragon_unicorn.models
{
    class Dragon : Creature
    {
        public Dragon(string name): base(name)
        {
            Intelligence = 25;
            SetHealth(50);
            Intelligence = 25;
        }
        public override int Attack(Creature target)
        {

            int dmg = target.Intelligence * 5;
            target.Intelligence = target.Intelligence - dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} intelligence!");
            SetHealth(Health + dmg);
            Console.WriteLine($"{Name} now has {Health} health and {target.Name} now has {target.Intelligence} intelligence");
            return Health;

        }
        public void Heal(Creature target)
        {
            int help = target.Intelligence * 10;
            target.Intelligence += help;
            Console.WriteLine($"{Name} has healed {target.Name} and now they have {target.Health} health!");

        }









        
    }

    
}