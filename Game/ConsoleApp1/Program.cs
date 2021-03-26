using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Character Bomj = new Looter();
            Enemy Skin = new Satanist();
            Fight(Bomj, Skin);
        }
        static void Fight(Character a, Enemy b)
        {
            int i = 0;
            while ((a.health != 0)||(b.health != 0))
            {                
                i += 1;
                if (i % a.attack_speed == 0)
                {
                    b.health -= a.damage;
                    a.mana -= a.mana_usage;
                }
                if (i%b.attack_speed == 0)
                {
                    a.health -= b.damage;
                }
            }
            if (a.health == 0) Console.WriteLine($"Победил {b.class_name}");
            else Console.WriteLine($"Победил {a.class_name}");
        }
    }
    

    
    
}
