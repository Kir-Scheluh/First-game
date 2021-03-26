using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Character
    {
        public string class_name;
        public int health;
        public int attack_speed;
        public int damage;
        public int mana = 100;
        public int mana_usage;
    }
    class Looter : Character
    {
        public Looter()
        {
            class_name = "Лутер помоек";
            health = 100;
            attack_speed = 100;
            damage = 30;
            mana_usage = 35;
        }
    }

    class Shit_Thrower : Character
    {
        public int arrows = 20;
        public Shit_Thrower()
        {
            class_name = "Метатель говна";
            health = 75;
            attack_speed = 150;
            damage = 60;
            mana_usage = 30;
        }
    }

    class Puker : Character
    {
        public Puker()
        {
            class_name = "Блеватель";
            health = 80;
            attack_speed = 100;
            damage = 45;
            mana_usage = 10;
        }
    }
}
