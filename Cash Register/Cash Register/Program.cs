namespace Cash_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orange = new Product(15, 1, "Orange");
            var fanta = new Product(2, 2, "Fanta");
            var pizza = new Product(2, 15, "Pepperoni Pizza");
            var milk = new Product(3, 1, "Cow Milk");
            var TV = new Product(1, 500, "Sony TV");

            var cashRegister = new CashRegister(pizza);
            cashRegister.AddProd(fanta);
            cashRegister.AddProd(orange);
            cashRegister.AddProd(milk);
            cashRegister.AddProd(TV);
            cashRegister.BuyProd("fanta");
            cashRegister.SaveAs("list.json");
            Console.WriteLine(cashRegister.ToString());
        }
    }
}