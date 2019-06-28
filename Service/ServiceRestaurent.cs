using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerTerminal.Service
{
    class ServiceRestaurent : AbstractServiceRestaurent
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


        protected override void ServiceTable()
        {
            serviceTable.confirmationTable("Table Eiffel");
            serviceTerminal.getManager();
        }

        protected override void ServiceHome(String nameClient,String addressClient)
        {
            Client c = new Client(nameClient, addressClient);
            serviceHome.getConfirmationAtHome(c);
            serviceHome.serviceHome();

        }

        protected override void ServiceAtTheTerminal()
        {
            serviceTerminal.confirmationTerminal();
            serviceTerminal.getManager();

        }

    }
}
