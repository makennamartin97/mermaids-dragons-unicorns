using System;

namespace mermaid_dragon_unicorn.models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Dragon dragon1 = new Dragon("Harry the Dragon");
            Unicorn unicorn1 = new Unicorn("Sparkle the Unicorn");
            Mermaid mermaid1 = new Mermaid("Kenna the Mermaid");
            System.Console.WriteLine("******************************** Starting Game *********************************");


            Console.ForegroundColor = ConsoleColor.Cyan;
            dragon1.Attack(unicorn1);
            mermaid1.Attack(dragon1);
            unicorn1.Steal(dragon1);
            dragon1.Attack(mermaid1);
            mermaid1.HealingSpell();
            dragon1.Attack(mermaid1);
            dragon1.Heal(mermaid1);
            dragon1.Stats();
            mermaid1.Stats();
            unicorn1.Stats();
            unicorn1.Attack(mermaid1);
            mermaid1.Attack(unicorn1);
            dragon1.Attack(mermaid1);

            unicorn1.Stats();
            mermaid1.Stats();
            dragon1.Stats();

        }
    }
}
