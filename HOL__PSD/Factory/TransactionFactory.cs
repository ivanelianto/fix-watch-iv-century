using HOL__PSD.Model;
using System;

namespace HOL__PSD.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction CreateHeader(string username)
        {
            HeaderTransaction headerTransaction = new HeaderTransaction()
            {
                user_id = username,
                occurance = DateTime.Now
            };

            return headerTransaction;
        }

        public static DetailTransaction CreateDetail(int headerTransactionId, Cart cart)
        {
            DetailTransaction detailTransaction = new DetailTransaction()
            {
                trans_id = headerTransactionId,
                product_id = cart.Product.id,
                price = cart.Product.price,
                quantity = cart.Quantity
            };

            return detailTransaction;
        }
    }
}