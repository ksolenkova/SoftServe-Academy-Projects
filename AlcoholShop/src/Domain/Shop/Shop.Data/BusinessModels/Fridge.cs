﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class Fridge : Appliance
    {
        public Fridge(string name, int degree, bool isButtonOn) : base(name, degree, isButtonOn)
        {
        }
    }
}
