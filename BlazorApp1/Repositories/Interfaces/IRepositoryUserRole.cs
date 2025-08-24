using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Repositories.Interfaces
{
	public interface IRepositoryUserRole : IRepositoryBase<IdentityUserRole<Guid>>
	{
	}
}
