using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal.Service
{
    class ServiceRestaurent
    {
        private ServiceAtHome serviceHome;
        private ServiceAtTheTerminal serviceTerminal;
        private ServiceTable serviceTable;


        public ServiceRestaurent()
        {
            serviceHome = new ServiceAtHome();
            serviceTerminal = new ServiceAtTheTerminal();
            serviceTable = new ServiceTable();
        }


        public void ServiceTable()
        {
            serviceTable.confirmationTable("Table Eiffel");
            serviceTerminal.getManager();
        }

        public void ServiceHome(String nameClient,String addressClient)
        {
            Client c = new Client(nameClient, addressClient);
            serviceHome.getConfirmationAtHome(c);
            serviceHome.serviceHome();

        }

        public void ServiceAtTheTerminal()
        {
            serviceTerminal.confirmationTerminal();
            serviceTerminal.getManager();

        }

    }
}
