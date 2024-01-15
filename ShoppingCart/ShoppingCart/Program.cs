namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var products = new Product[]
            {
                new Product("A", 40),
                new Product("B", 70),
                new Product("C", 30),
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.ShowCart(products);
            shoppingCart.Buy("A", 1);
            shoppingCart.ShowCart(products);
            shoppingCart.Buy("B", 3);
            shoppingCart.ShowCart(products);
            shoppingCart.Buy("A", 4);
            shoppingCart.ShowCart(products);
        }
    }
}
