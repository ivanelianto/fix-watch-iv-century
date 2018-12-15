using HOL__PSD.Model;
using System.Linq;

namespace HOL__PSD.Repository
{
    public class ProductRepository
    {
        public static void DecreaseStock(int id, int quantity)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                Product product = db.Product.Where(x => x.id == id).FirstOrDefault();
                product.stock -= quantity;

                db.SaveChanges();
            }
        }
    }
}