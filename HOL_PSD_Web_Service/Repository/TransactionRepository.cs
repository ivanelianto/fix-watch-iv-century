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
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                List<HeaderTransaction> headers = db.HeaderTransaction
                    .Where(x => x.user_id == username)
                    .Select(x => x)
                    .ToList();

                foreach (var header in headers)
                {
                    List<DetailTransaction> details = db.DetailTransaction
                        .Include("Product")
                        .Where(detail => detail.trans_id == header.id)
                        .Select(detail => detail)
                        .ToList();

                    header.DetailTransaction = details;
                }

                return headers;
            }
        }
    }
}