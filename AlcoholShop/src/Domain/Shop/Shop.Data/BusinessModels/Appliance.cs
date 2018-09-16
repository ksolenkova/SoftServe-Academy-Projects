using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
    public abstract class Appliance
    {
        private string name;
        private int degree;
        private bool isButtonOn;

        public Appliance(string name, int degree, bool isButtonOn)
        {
            this.name = name;
            this.degree = degree;
            this.isButtonOn = isButtonOn;
        }

        public string Name { get { return name; } }

        public void PushButtonOn(string name)
        {
            if(!isButtonOn)
            {
                isButtonOn = true;
                Console.WriteLine(name + " is on.");
            }
            else
            {
                Console.WriteLine(name + " has been already turned on.");
            }
            Console.WriteLine();
        }

        public void PushButtonOff(string name)
        {
            if (isButtonOn)
            {
                isButtonOn = false;
                Console.WriteLine(name + " is off.");
            }
            else
            {
                Console.WriteLine(name + " has been already turned off.");
            }
            Console.WriteLine();
        }
        
    }
}
