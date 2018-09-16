using System;
namespace Shop.Data.BusinessModels

{
    public class Seller : Person
    {
        public Seller(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public int Sallary { get; set; }

        public void GetBonus(CandyShop candyShop)
        {
            if(candyShop.Income > 10)
            {
                Sallary += 1;
                Console.WriteLine($"Congratulations! Your sallary is {Sallary} lv.");
            }
            else
            {
                Console.WriteLine("You need to work harder, bitch!");
            }
        }
    }
}
