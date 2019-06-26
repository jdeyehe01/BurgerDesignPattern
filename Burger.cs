using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
     class Burger
    {
        private String typeBurger;
        private Dictionary<String, String> ingredients = new Dictionary<string, string>();

        public Burger(String type)
        {
            this.typeBurger = type;
        }

        public String this[String key]
        {
            get { return ingredients[key]; }
            set { ingredients[key] = value; }
        }


        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich:", typeBurger);
            Console.WriteLine(" Bread: ", ingredients["bread"]);
            Console.WriteLine(" Meat: ", ingredients["meat"]);
            Console.WriteLine(" Cheese: ", ingredients["cheese"]);
            Console.WriteLine(" Veggies: ", ingredients["veggies"]);
            Console.WriteLine(" Condiments: ", ingredients["condiments"]);
        }
    }

    }

   
}
