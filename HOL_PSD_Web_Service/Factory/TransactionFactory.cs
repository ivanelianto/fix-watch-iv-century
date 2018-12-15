using HOL_PSD_Web_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOL_PSD_Web_Service.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction CreateHeader(
            int id,
            string user_id,
            DateTime occurance,
            List<DetailTransaction> detailTransaction)
        {
            return new HeaderTransaction()
            {
                id = id,
                user_id = user_id,
                occurance = occurance,
                DetailTransaction= detailTransaction
            };
        }

        public static DetailTransaction CreateDetail(
                int headerId,
                Product product,
                decimal price,
                int quantity
            )
        {
            return new DetailTransaction()
            {
                trans_id = headerId,
                product_id = product.id,
                Product = product,
                price = price,
                quantity = quantity
            };
        }
    }
}