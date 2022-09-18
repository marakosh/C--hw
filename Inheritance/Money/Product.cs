using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Money
{
    internal class Product : Money
    {
        private double change;
        public void SetChange()
        {
            if (price == 0) { Price(); }
            Console.WriteLine("Enter the amount for how much you want to change the price: (example - 1st input:12.   2nd input:32.   will be 12.32)");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            this.change = first + second / 100f;
        }
        public void Change()
        {
            Console.WriteLine("Do you want to increase[1] or decrease[2] the prise?");
            int choice = Convert.ToInt32(Console.ReadLine());
            SetChange();
            if (choice == 1)
            {
                price -= change;
            }
            else if (choice == 2)
            {
                price += change;
            }
            else
            {
                Console.WriteLine("WRONG INPUT!");
            }
            Console.WriteLine($"new price {price}");
        }
    }
}
