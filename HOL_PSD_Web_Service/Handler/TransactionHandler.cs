using HOL_PSD_Web_Service.Factory;
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
            List<HeaderTransaction> result = new List<HeaderTransaction>();

            var headerTransactions = TransactionRepository.FindByUsername(username);

            if (headerTransactions.Count < 1)
                return "";
            else
            {
                foreach (var header in headerTransactions)
                {
                    List<DetailTransaction> finalDetail = new List<DetailTransaction>();

                    List<DetailTransaction> detailTransactions = TransactionRepository.FindDetailByTransactionId(header.id);

                    foreach(var detail in detailTransactions)
                    {
                        Product product = ProductRepository.FindById(detail.product_id);

                        finalDetail.Add(TransactionFactory.CreateDetail(
                            header.id,
                            product, 
                            detail.price.Value, 
                            detail.quantity.Value));
                    }

                    HeaderTransaction finalHeader = TransactionFactory.CreateHeader(
                            header.id,
                            header.user_id,
                            header.occurance.Value,
                            finalDetail
                        );

                    result.Add(finalHeader);
                }

                return JsonHandler.Encode(result);
            }
        }
    }
}