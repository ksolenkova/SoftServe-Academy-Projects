﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class CandyShop : BaseShop
    {
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
