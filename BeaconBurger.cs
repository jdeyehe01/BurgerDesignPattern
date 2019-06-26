using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class BeaconBurger : IBurger
    {

        BeaconBurger burger ();
        public IBurgerBuilder AddExtra(PortionSize portionSize, IExtra extra)
        {
        }

        public IBurger GetBurger()
        {

            return this.burger;
        }
    }
}
