using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Entities;
using BlazorApp1.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryApplicationUser : RepositoryBase<ApplicationUser>, IRepositoryApplicationUser
	{
        public RepositoryApplicationUser(ShowTimeContext context) : base(context) { }
    }
}
  