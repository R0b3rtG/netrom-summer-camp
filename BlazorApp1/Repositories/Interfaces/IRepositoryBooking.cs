using BlazorApp1.Entities;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IRepositoryBooking : IRepositoryBase<Booking>
    {
        Task<IEnumerable<Booking>> GetPaidBookingsAsync(string email);
        Task<IEnumerable<Booking>> GetAllPaidBookingsAsync();
		Task<IEnumerable<Booking>> GetUnpaidBookingsAsync(string email);
        Task<IEnumerable<Booking>> GetRefundedBookingsAsync();
    }
}
