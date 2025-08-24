using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Repositories.Interfaces
{
	public interface IRepositoryRole : IRepositoryBase<IdentityRole<Guid>>
	{
	}
}
