using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Item
    {
        public string item_name;
        public int health_boost=0;
        public int damage_boost=0;
        public int speed_boost=0;
    }

    class Jacket : Item
    {
        public Jacket()
        {
            item_name = "Обоссанный пуховик";
            damage_boost = 15;
        }
    }

    class Cart : Item
    {
        public Cart()
        {
            item_name = "Телега из 5ки";
            speed_boost = 15;
        }
    }

    class Potion : Item
    {
        public Potion()
        {
            item_name = "Бутылка боярышника";
            health_boost = 15;
        }
    }
}
