using HOL__PSD.Model;
using System.Linq;

namespace HOL__PSD.Repository
{
    public class TransactionRepository
    {
        public static HeaderTransaction InsertHeaderTransaction(HeaderTransaction headerTransaction)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                db.HeaderTransaction.Add(headerTransaction);
                db.SaveChanges();

                return headerTransaction;
            }
        }

        public static DetailTransaction InsertDetailTransaction(DetailTransaction detailTransaction)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                db.DetailTransaction.Add(detailTransaction);
                db.SaveChanges();

                int productId = detailTransaction.product_id;
                int quantity = detailTransaction.quantity.Value;
                ProductRepository.DecreaseStock(productId, quantity);

                return detailTransaction;
            }
        }
    }
}