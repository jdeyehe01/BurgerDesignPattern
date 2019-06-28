using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal.Service
{
    class Client
    {

        private String name { get; set; }
        private String address { get; set; }

        public Client (String name, String address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
