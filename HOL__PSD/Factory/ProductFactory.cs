using HOL__PSD.Model;

namespace HOL__PSD.Factory
{
    public static class ProductFactory
    {
        public static Product Create()
        {
            return new Product();
        }

        public static Product Create(string name, decimal price)
        {
            Product product = new Product()
            {
                name = name,
                price = price
            };

            return product;
        }

        public static Product Create(int id, string name, decimal price, int stock)
        {
            Product product = new Product()
            {
                id = id,
                name = name,
                price = price,
                stock = stock
            };

            return product;
        }
    }
}