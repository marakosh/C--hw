using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Money
{
    internal class Money
    {
        protected double price = 0;
        private int whole;
        private int penny;
        public void Price()
        {
            Console.WriteLine("Enter amount of whole currency: ");
            whole = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amoubt of pennies");
            penny = Convert.ToInt32(Console.ReadLine());
            PrintPrice();
        }

        public double Total()
        {
            double price = whole + penny / 100d;
            this.price = (float)price;
            return (float)price;
        }
        public void PrintPrice()
        {
            Console.WriteLine(Total());
        }
    }
}
