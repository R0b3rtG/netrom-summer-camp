using BlazorApp1.Context;
using BlazorApp1.Entities;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories.Implementation
{
	public class RepositoryFestival : RepositoryBase<Festival>, IRepositoryFestival
	{
		public RepositoryFestival(ShowTimeContext context) : base(context) { }

		public async Task<IEnumerable<Festival>> GetAllFestivalWithBands()
		{
			return await Context.Festivals
				.Include(x => x.FestivalBands)
				.ThenInclude(x => x.Band)
				.ToListAsync();
		}

		public async Task<IEnumerable<Festival>> GetFestivalById(Guid id)
		{
			return (await Context.Festivals
				.Include(x => x.FestivalBands)
				.ThenInclude(x => x.Band)
				.Include(x => x.Bookings).ToListAsync())
				.Where(x => x.Id == id);
        }
	}
}
