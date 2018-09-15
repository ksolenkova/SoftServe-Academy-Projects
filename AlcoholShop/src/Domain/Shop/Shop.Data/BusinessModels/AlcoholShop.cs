using System;
using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {
        private string name;
        private List<Table> tables;
        private List<Waitress> waitress;
        private Fridge fridge;

        public AlcoholShop(string name, List<Table> tables, List<Waitress> waitress, Fridge fridge)
        {
            this.name = name;
            this.tables = tables;
            this.waitress = waitress;
            this.fridge = fridge;
        }

        public string Name { get { return name; } set { name = value; } }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Alcohol))
            {
                return false;
            }
            return true;
        }
    }
}
