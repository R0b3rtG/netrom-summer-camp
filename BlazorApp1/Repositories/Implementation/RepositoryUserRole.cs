using BlazorApp1.Context;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Repositories.Implementation
{
	public class RepositoryUserRole : RepositoryBase<IdentityUserRole<Guid>>, IRepositoryUserRole
	{
		public RepositoryUserRole(ShowTimeContext context) : base(context) { }
	}
}
