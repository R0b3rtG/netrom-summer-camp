using BlazorApp1.Context;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Repositories.Implementation
{
	public class RepositoryRole : RepositoryBase<IdentityRole<Guid>>, IRepositoryRole
	{
		public RepositoryRole(ShowTimeContext context) : base(context) { }
	}
}
