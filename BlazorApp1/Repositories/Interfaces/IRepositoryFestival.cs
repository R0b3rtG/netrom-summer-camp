using BlazorApp1.Entities;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IRepositoryFestival : IRepositoryBase<Festival>
    {
		Task<IEnumerable<Festival>> GetAllFestivalWithBands();

	}
}
