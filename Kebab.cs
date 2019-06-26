using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class Kebab : BurgerBuilder
    {
        public Kebab()
        {
            burger = new Burger("Kebab");
        }

        public override void AddBread()
        {
            burger["bread"] = "Burns";
        }

        public override void AddCheese()
        {
            burger["cheese"] = "emmental";
        }

        public override void AddMeats()
        {
            burger["meats"] = "Lamb";
        }

        public override void AddVeggies()
        {
            burger["veggies"] = "Lettuce, Tomato,onion";
        }

        public override void AddCondiments()
        {
            burger["condiments"] = "Mayo";
        }
    }       
 }
