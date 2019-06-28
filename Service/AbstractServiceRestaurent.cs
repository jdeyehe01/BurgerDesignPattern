using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal.Service
{
    public abstract class AbstractServiceRestaurent
    {
        protected abstract void ServiceTable();
        protected abstract void ServiceHome(String nameClient, String addressClient);

        protected abstract void ServiceAtTheTerminal();
    }
}
