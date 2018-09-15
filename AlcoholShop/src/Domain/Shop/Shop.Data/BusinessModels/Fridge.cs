using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class Fridge
    {
        private List<Alcohol> alcohols;

        public void PutInFridge(List<Good> goods)
        {
            var alcoholInFridge = new List<string>();
            Console.Write("In the fridge we have: ");

            foreach (var good in goods)
            {
                if(good is Alcohol)
                {
                    alcoholInFridge.Add(good.Name);
                    
                } 
            }
           
            var alcoholNames = string.Join(", ", alcoholInFridge);
            Console.WriteLine(alcoholNames);
        }
    }
}
