using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public class Fridge : Appliance
    {
        public Fridge(string name, int degree, bool isButtonOn) : base(name, degree, isButtonOn)
        {
        }

        public override void ChangeDegree(bool isUp, Appliance appliance)
        {
            if (appliance.IsButtonOn)
            {
                if (isUp && appliance.Degree < 7)
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
                Console.WriteLine("You should turn the fridge on!");
            }
            Console.WriteLine();
        }
    }
}

