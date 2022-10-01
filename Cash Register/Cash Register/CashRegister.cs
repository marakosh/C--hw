using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cash_Register
{
    public class CashRegister
    {
        private Dictionary<string, Product> Products;
        public CashRegister(params Product[] product)
        {
            Products = new Dictionary<string, Product>();
            foreach (var item in product)
            {
                this.Products.Add(item.Title, item);
            }
        }
        public Product this[string Title]
        {
            get => this.Products[Title];
        }

        public void AddProd(Product Product)    // adds a product
        {
            if (!Products.ContainsKey(Product.Title))
                Products.Add(Product.Title, Product);
        }

        public void DelProd(Product Product)    // removes a product
        {
            if (Products.ContainsKey(Product.Title)) 
                this.Products.Remove(Product.Title);
        }

        public void AddCount(string Title, int Count)    // adds a count
        {
            if (Products.ContainsKey(Title)) 
                this.Products[Title].Count = Count;
        }

        public void BuyProd(string Title)    // buys a product
        {
            if (Products.ContainsKey(Title)) 
                this.Products[Title].Count--;
        }

        public void PriceProd(string Title, int Price)   // sets a price of a product
        {
            if (Products.ContainsKey(Title)) 
                this.Products[Title].Price = Price;
        }

        public void SaveAs(string Name)
        {
            using FileStream sw = new FileStream(Name, FileMode.Create);
            using StreamWriter sw2 = new StreamWriter(sw);
            var options = new JsonSerializerOptions() { WriteIndented = true };
            var serializer = JsonSerializer.Serialize(this.Products, options);
            sw2.Write(serializer);
        }
        public override string ToString()
        {
            var AllProduct = new StringBuilder(this.Products.Count * 7);
            foreach (var item in this.Products)
            {
                AllProduct.AppendLine(item.Value.ToString());
            }
            return AllProduct.ToString();
        }
    }
}
