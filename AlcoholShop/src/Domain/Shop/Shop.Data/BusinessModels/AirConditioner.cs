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

        public override void ChangeDegree(bool isUp, Appliance appliance)
        {
            if (appliance.IsButtonOn)
            {
                if (isUp && appliance.Degree < 35)
                {
                    appliance.Degree++;
                    Console.WriteLine($"The degree is up and is {appliance.Degree}C.");
                }
                else if (!isUp && appliance.Degree > 0)
                {
                    appliance.Degree--;
                    Console.WriteLine($"The degree is down and is {appliance.Degree}C.");

                }
                else
                {
                    Console.WriteLine("It doesn't apply to the conditions for changing the degrees!");
                }
            }
            else
            {
                Console.WriteLine("You should turn the air conditioner on!");
            }
            Console.WriteLine();
        }
    }
               
    
    
}
