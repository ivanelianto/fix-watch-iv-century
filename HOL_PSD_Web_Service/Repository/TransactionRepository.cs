using HOL_PSD_Web_Service.Model;
using System.Collections.Generic;
using System.Linq;

namespace HOL_PSD_Web_Service.Repository
{
    public class TransactionRepository
    {
        public static List<HeaderTransaction> FindByUsername(string username)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;

                return db.HeaderTransaction
                    .Where(x => x.user_id == username)
                    .Select(x => x)
                    .ToList();
            }
        }

        public static List<DetailTransaction> FindDetailByTransactionId(int transactionId)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;

                return db.DetailTransaction
                    .Where(x => x.trans_id == transactionId)
                    .Select(x => x)
                    .ToList();
            }
        }
    }
}