using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class AirConditioner : Appliance
    {
        private string color;

        public AirConditioner(string name, int degree, bool isButtonOn, string color) : base(name, degree, isButtonOn)
        {
            this.color = color;
        }
    }
}
