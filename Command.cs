using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal
{
    class Command
    {
        private String status { get; set; }
        List<Menu> menus { get; }
        List<Produit> products {get;}

        DateTime date { get;set}
    }
}
