using BlazorApp1.Context;
using BlazorApp1.Entities;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeContext context) : base(context) { }
		public async Task<IEnumerable<Booking>> GetPaidBookingsAsync(string email)
        {
			return await Context.Bookings
				.Include(x => x.Festival)
				.Where(x => x.Email == email && x.Purchased == true)
				.ToListAsync();
		}
		public async Task<IEnumerable<Booking>> GetAllPaidBookingsAsync()
		{
			return await Context.Bookings
				.Include(x => x.Festival)
				.Where(x => x.Purchased == true)
				.ToListAsync();
		}
		public async Task<IEnumerable<Booking>> GetUnpaidBookingsAsync(string email) {
            return await Context.Bookings
                    .Include(x => x.Festival)
                    .Where(x => x.Email == email && x.Purchased == false && x.RefundRequested == false)
                    .ToListAsync();
        }
        public async Task<IEnumerable<Booking>> GetRefundedBookingsAsync()
        {
            return await Context.Bookings
                .Include(x => x.Festival)
                .Where(x => x.Purchased == true && x.RefundRequested == true)
                .ToListAsync();
        }
    }
}
