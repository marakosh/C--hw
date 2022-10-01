using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register
{
    public class Product
    {
        public int Count { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }

        public Product(int count, int price, string title)
        {
            Count = count;
            Price = price;
            Title = title;
        }
        public override string ToString()
        {
            return $"Count - {this.Count}\n" +  
                   $"Price - {this.Price}\n" +
                   $"Name - {this.Title}\n";
        }
    }
}
