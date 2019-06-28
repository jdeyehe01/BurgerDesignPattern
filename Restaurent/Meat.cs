using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class Meat : IExtra
    {
        private PortionSize size;
        public Meat(PortionSize size)
        {
            this.size = size;
        }
    }
}
