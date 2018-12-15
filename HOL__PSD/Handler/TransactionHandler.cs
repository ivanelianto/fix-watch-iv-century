using HOL__PSD.Factory;
using HOL__PSD.Model;
using HOL__PSD.Repository;
using System.Collections.Generic;

namespace HOL__PSD.Handler
{
    public class TransactionHandler
    {
        public static void Checkout(User user, List<Cart> carts)
        {
            HeaderTransaction headerTransaction = TransactionFactory.CreateHeader(user.username);
            int headerTransactionId = TransactionRepository.InsertHeaderTransaction(headerTransaction).id;

            foreach (var item in carts)
            {
                DetailTransaction detailTransaction = TransactionFactory.CreateDetail(headerTransactionId, item);
                TransactionRepository.InsertDetailTransaction(detailTransaction);
            }
        }
    }
}