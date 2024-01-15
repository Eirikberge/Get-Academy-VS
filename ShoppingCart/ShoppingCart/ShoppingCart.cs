using System.Linq;

namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<string> _productsInCart;
        private List<int> _shoppingCartCounts;

        public ShoppingCart()
        {
            _productsInCart = new List<string>();
            _shoppingCartCounts = new List<int>();
        }

        public void Buy(string productName, int count)
        {
            if (_productsInCart.Contains(productName))
            {
                var orderLineIndex = _productsInCart.IndexOf(productName);
                _shoppingCartCounts[orderLineIndex] += count;
            }
            else
            {
                _productsInCart.Add(productName);
                _shoppingCartCounts.Add(count);
            }

            Console.WriteLine($"Du kjøpte {count} stk. {productName}");
        }

        public void ShowCart(Product[] products)
        {
            if (_productsInCart.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }
            Console.WriteLine("Handlekurv:");

            var totalPrice = 0;

            for (int i = 0; i < _productsInCart.Count; i++)
            {
                var productName = _productsInCart[i];
                var count = _shoppingCartCounts[i];
                var product = Array.Find(products, p => p.Name == productName);

                if (product != null)
                {
                    var orderLinePrice = product.Price * count;
                    Console.WriteLine($"  {count} stk. {productName} a kr {product.Price} = {orderLinePrice}");
                    totalPrice += orderLinePrice;
                }
            }
            Console.WriteLine($"Totalpris: {totalPrice}");
        }
    }
}
