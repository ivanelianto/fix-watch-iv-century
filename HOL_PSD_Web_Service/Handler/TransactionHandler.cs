using HOL_PSD_Web_Service.Model;
using HOL_PSD_Web_Service.Repository;
using HOL_PSD_Web_Service.Util;
using System.Collections.Generic;
using System.Linq;

namespace HOL_PSD_Web_Service.Handler
{
    public class TransactionHandler
    {
        public static string FindByUsername(string username)
        {
            List<HeaderTransaction> headerTransactions = TransactionRepository.FindByUsername(username);

            if (headerTransactions.Count < 1)
                return "";
            else
            {

                return JsonHandler.Encode(
                        headerTransactions.Select(header => new
                        {
                            id = header.id,
                            user_id = header.user_id,
                            occurance = header.occurance.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                            details = header.DetailTransaction.Select(detail =>
                            new
                            {
                                product = new
                                {
                                    name = detail.Product.name,
                                    price = detail.Product.price
                                },
                                quantity = detail.quantity,
                                price = detail.price
                            })
                        }));
            }
        }
    }
}