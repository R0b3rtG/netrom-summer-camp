using BlazorApp1.Context;
using BlazorApp1.Entities;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryFestival : RepositoryBase<Festival>, IRepositoryFestival
    {
        public RepositoryFestival(ShowTimeContext context) : base(context) { }
    }
}
