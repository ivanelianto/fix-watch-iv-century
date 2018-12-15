using HOL__PSD.WebService;

namespace HOL__PSD.Service
{
    public class TransactionService
    {
        private static MainService service = null;

        private TransactionService() { }

        public static MainService GetInstance()
        {
            if (service == null)
                service = new MainService();

            return service;
        }
    }
}