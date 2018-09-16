using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class Table
    {
        private string name;
        private int seats;
        private List<Client> clients;
        private Waitress waitress;

        public Table(int seats, List<Client> clients, string name)
        {
            this.seats = seats;
            this.clients = clients;
            this.name = name;
        }

        public Waitress Waitress { get { return waitress; } set { waitress = value; } }
        public string Name { get { return name; } }
        public List<Client> Client { get { return clients; } set { clients = value; } }
     
        public void GetClientsNames(string name)
        {
            var names = new List<string>();
            Console.Write(name + " has these clients: ");

            foreach (var client in clients)
            {
                names.Add(client.FirstName);
            }
            string clientsName = string.Join(", ", names);
            Console.WriteLine(clientsName + '.');
        }
    }
}
