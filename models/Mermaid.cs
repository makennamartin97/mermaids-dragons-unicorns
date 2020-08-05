using System;
namespace mermaid_dragon_unicorn.models
{
    class Mermaid : Creature
    {
        public Mermaid(string name): base(name)
        {
            SetHealth(200);
        }
        public override int Attack(Creature target)
        {
            if(target.Health < 50)
            {
                target.SetHealth(0);
                System.Console.WriteLine($"{target.Name} has been killed");
                
            }
            System.Console.WriteLine($"{Name} tried to kill {target.Name} but failed");
            return target.Health;
        }
        public void HealingSpell()
        {
            SetHealth(200);
            Console.WriteLine($"{Name} recovering their health to {Health}");

        }
    }
}