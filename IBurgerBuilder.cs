using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    abstract class BurgerBuilder
    {
        protected Burger burger;

        public Burger Burger
        {
            get { return burger; }
        }


        public abstract void AddBread();

        public abstract void AddMeats();

        public abstract void AddCheese();

        public abstract void AddCondiments();

        public abstract void AddVeggies();




    }
}
