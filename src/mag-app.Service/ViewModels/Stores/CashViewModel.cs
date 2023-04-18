using mag_app.Domain.Entities.Stores;

namespace mag_app.Service.ViewModels.Stores
{
    public class CashViewModel
    {
        public string CashName { get; set; } = string.Empty;

        public long StoreId { get; set; }
        public string StoreName { get; set; } = string.Empty;

        public static implicit operator Cash(CashViewModel cash)
        {
            return new Cash()
            {
                CashName = cash.CashName,
                StoreId = cash.StoreId,
                StoreName = cash.StoreName
            };
        }
    }
}
