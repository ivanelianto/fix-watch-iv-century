using HOL__PSD.Model;

namespace HOL__PSD.Factory
{
    public class CartFactory
    {
        public static Cart Create(int quantity, Product product)
        {
            Cart cart = new Cart()
            {
                Quantity = quantity,
                Product = product
            };

            return cart;
        }
    }
}