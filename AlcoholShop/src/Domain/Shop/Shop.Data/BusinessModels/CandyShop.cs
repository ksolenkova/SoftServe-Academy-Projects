using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class CandyShop : BaseShop
    {
        private Seller seller;
        private AirConditioner airConditioner;

        public CandyShop(Seller seller, AirConditioner airConditioner)
        {
            this.seller = seller;
            this.airConditioner = airConditioner;
        }

        public AirConditioner AirConditioner { get { return airConditioner; } set { airConditioner = value; } }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Candy))
            {
                return false;
            }
            return true;
        }
    }
}
