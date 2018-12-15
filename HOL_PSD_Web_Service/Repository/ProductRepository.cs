using HOL_PSD_Web_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOL_PSD_Web_Service.Repository
{
    public class ProductRepository
    {
        public static Product FindById(int id)
        {
            using (WatchShopEntities db = new WatchShopEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;

                return db.Product.Find(new object[] { id });
            }
        }
    }
}