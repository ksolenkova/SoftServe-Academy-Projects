using Shop.Data.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class MainShop
    { 
        static void Main(string[] args)
        {
            var pesho = new Client("Pesho", "Petrov", 21);
            var gosho = new Client("Gosho", "Goshov", 18);
            var mariika = new Client("Mariika", "Petrova", 25);
            var canko = new Client("Canko", "Mitkov", 36);
            var mitko = new Client("Mitko", "Mitkov", 52);
            var goshka = new Client("Goshka", "Mitkova", 50);

            var firstClients = new List<Client>();
            firstClients.Add(pesho);
            firstClients.Add(gosho);
            firstClients.Add(mariika);

            var secondClients = new List<Client>();
            secondClients.Add(canko);
            secondClients.Add(mitko);
            secondClients.Add(goshka);


            var waitressPenka = new Waitress("Penka", "Penkova", 35);
            var waitressSuzi = new Waitress("Suzi", "Avramova", 30);

            var waitresses = new List<Waitress>();
            waitresses.Add(waitressPenka);
            waitresses.Add(waitressSuzi);

            var table1 = new Table(3, firstClients);
            table1.Waitress = waitressPenka;
            Console.WriteLine($"Avanti's table1 waitress is {table1.Waitress.FirstName}.");
            table1.GetClientsNames();

            var table2 = new Table(3, secondClients);
            table2.Waitress = waitressSuzi;
            Console.WriteLine($"Avanti's table2 waitress is {table2.Waitress.FirstName}.");
            table2.GetClientsNames();

            var tables = new List<Table>();
            tables.Add(table1);
            tables.Add(table2);

            var fridgeSamsung = new Fridge();

            var alcoholShop = new AlcoholShop("Avanti", tables, waitresses, fridgeSamsung);

            var vodka = new Alcohol("Vodka",25);
            var whiskey = new Alcohol("Whiskey",159);
            var beer = new Alcohol("Beer", 2);
            var candy = new Candy("bonbons", 5);

            alcoholShop.AddGood(candy);
            alcoholShop.AddGood(vodka);
            alcoholShop.AddGood(whiskey);
            alcoholShop.AddGood(beer);

            fridgeSamsung.PutInFridge(alcoholShop.Goods);

            Console.WriteLine($"Income before---> {alcoholShop.Income} " +
               $"Count: {alcoholShop.Goods.Count()}");

            alcoholShop.Sell(beer);
    

            Console.WriteLine($"Income after---> {alcoholShop.Income} " +
               $"Count: {alcoholShop.Goods.Count()}");
            
        }
    }
}
