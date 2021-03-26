using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enemy
    {
        public string class_name;
        public int health;
        public int attack_speed;
        public int damage;        
    }

    class Satanist : Enemy
    {
        public Satanist()
        {
            class_name = "Сатанист-убийца";
            health = 75;
            attack_speed = 100;
            damage = 25;
        }

        class Skinhead : Enemy
        {
            public Skinhead()
            {
                class_name = "Скинхед";
                health = 300;
                attack_speed = 10;
                damage = 300;
            }
        }
        class Schoolboy : Enemy
        {
            public Schoolboy()
            {
                class_name = "Бухой школьник";
                health = 70;
                attack_speed = 75;
                damage = 20;
            }
        }
        class Cop : Enemy
        {
            public Cop()
            {
                class_name = "Участковый";
                health = 500;
                attack_speed = 300;
                damage = 100;
            }
        }

    }
}
