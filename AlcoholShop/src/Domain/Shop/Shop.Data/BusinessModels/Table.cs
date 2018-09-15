using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class Table
    {
        private int seats;
        private List<Client> clients;
        private Waitress waitress;

        public Table(int seats, List<Client> clients)
        {
            this.seats = seats;
            this.clients = clients;
        }

        public Waitress Waitress { get { return waitress; } set { waitress = value; } }
     
        public void GetClientsNames()
        {
            var names = new List<string>();
            Console.Write("Table1 has these clients: ");

            foreach (var client in clients)
            {
                names.Add(client.FirstName);
            }
            string clientsName = string.Join(", ", names);
            Console.WriteLine(clientsName);
        }
    }
}
