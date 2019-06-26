using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddExtra(PortionSize portionSize, IExtra extra);

        IBurger GetBurger();
    }
}
