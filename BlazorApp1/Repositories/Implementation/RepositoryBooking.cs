using BlazorApp1.Context;
using BlazorApp1.Entities;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeContext context) : base(context) { }
    }
}
