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
            Console.WriteLine("====== Alcohol Shop =====");
            Console.WriteLine();

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

            var table1 = new Table(3, firstClients, "Table 1");
            table1.Waitress = waitressPenka;
            Console.WriteLine($"Avanti's table 1 waitress is {table1.Waitress.FirstName}.");
            table1.GetClientsNames(table1.Name);
            Console.WriteLine();  

            var table2 = new Table(3, secondClients, "Table 2");
            table2.Waitress = waitressSuzi;
            Console.WriteLine($"Avanti's table 2 waitress is {table2.Waitress.FirstName}.");
            table2.GetClientsNames(table2.Name);
            Console.WriteLine();

            var tables = new List<Table>();
            tables.Add(table1);
            tables.Add(table2);

            var fridgeSamsung = new Fridge("Fridge Samsung", 4, true);
            fridgeSamsung.PushButtonOn(fridgeSamsung.Name);
            fridgeSamsung.PushButtonOff(fridgeSamsung.Name);
            fridgeSamsung.PushButtonOn(fridgeSamsung.Name);
            fridgeSamsung.ChangeDegree(true, fridgeSamsung);
            Console.WriteLine();
            
            var alcoholShop = new AlcoholShop("Avanti", tables, waitresses, fridgeSamsung);
            var avantiLtd = new Company("Avanti LTD");
            alcoholShop.Company = avantiLtd;
            Console.WriteLine("Alcohol shop company's name is " + alcoholShop.Company.Name + '.');
            Console.WriteLine();
          
            var adressAlcoholShop = new Address("Sofia", "Lincoln street");
            alcoholShop.Address = adressAlcoholShop;
            Console.WriteLine($"Alcohol shop's address is {alcoholShop.Address.City}, {alcoholShop.Address.Street}.");
            Console.WriteLine();

            var vodka = new Alcohol("Vodka", 25);
            var whiskey = new Alcohol("Whiskey", 159);
            var beer = new Alcohol("Beer", 2);
            var candy = new Candy("Bonbon", 5);
            
            alcoholShop.AddGood(candy);
            alcoholShop.AddGood(vodka);
            alcoholShop.AddGood(whiskey);
            alcoholShop.AddGood(beer);

            Console.WriteLine($"In {alcoholShop.Name}'s income before ---> {alcoholShop.Income} lv. " +
               $"Count: {alcoholShop.Goods.Count()}");

            alcoholShop.Sell(beer);
    
            Console.WriteLine($"In {alcoholShop.Name}'s income after ---> {alcoholShop.Income} lv. " +
               $"Count: {alcoholShop.Goods.Count()}");
            Console.WriteLine();

            Console.WriteLine("====== Candy Shop =====");

            var sellerCandyShop = new Seller("Ani", "Petkova", 21);
            sellerCandyShop.Sallary = 750;

            var airConditionerDaikin = new AirConditioner("Air conditioner  Daikin", 23, false, "purple");

            var candyShop = new CandyShop(sellerCandyShop, airConditionerDaikin);
            Console.WriteLine();
          
            var candyLtd = new Company("Candy LTD");
            candyShop.Company = candyLtd;

            var addressCandyShop = new Address("Sofia", "Lublyana street");
            candyShop.Address = addressCandyShop;
            Console.WriteLine($"The address of {candyShop.Company.Name} is {candyShop.Address.City}, {candyShop.Address.Street}.");

            airConditionerDaikin.PushButtonOn(airConditionerDaikin.Name);
            airConditionerDaikin.PushButtonOff(airConditionerDaikin.Name);
            airConditionerDaikin.PushButtonOn(airConditionerDaikin.Name);
            airConditionerDaikin.ChangeDegree(false, airConditionerDaikin);
            Console.WriteLine();

            var chocolate = new Candy("Chocolate", 1.8m);
            var candyBar = new Candy("Candy bar", 1.5m);
            var sweet = new Candy("Sweet", 2.5m);
            var expensiveSweet = new Candy("ExpensiveSweet", 25);

            candyShop.AddGood(chocolate);
            candyShop.AddGood(candy);
            candyShop.AddGood(candyBar);
            candyShop.AddGood(sweet);
            candyShop.AddGood(beer);
            candyShop.AddGood(expensiveSweet);

            Console.WriteLine($"In {candyShop.Company.Name}'s income before ---> {candyShop.Income} lv. " +
               $"Count: {candyShop.Goods.Count()}");
            candyShop.Sell(chocolate);
            Console.WriteLine($"In {candyShop.Company.Name}'s income after ---> {candyShop.Income} lv. " +
               $"Count: {candyShop.Goods.Count()}");
            Console.WriteLine();

            sellerCandyShop.GetBonus(candyShop);
            candyShop.Sell(expensiveSweet);
            sellerCandyShop.GetBonus(candyShop);
        }
    }
}
