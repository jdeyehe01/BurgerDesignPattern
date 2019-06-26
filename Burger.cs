using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class Burger
    {
        private String type;
        private Dictionary<PortionSize, IExtra> ingredients = new Dictionary<PortionSize, IExtra>();


        public Burger(String type)
        {
            this.type = type;
        }

        public void AddIngredient(PortionSize size, IExtra ingredient)
        {
            ingredients.Add(size, ingredient);
        }


        public void Show()
        {
            foreach(var item in ingredients)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
