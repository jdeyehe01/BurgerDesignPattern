using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class MakeBurger
    {
        public void MakeBurgerLine(BurgerBuilder burgerBuilder)
        {
            burgerBuilder.AddBread();
            burgerBuilder.AddMeats();
            burgerBuilder.AddCheese();
            burgerBuilder.AddVeggies();
            burgerBuilder.AddCondiments();

        }

    }
}
