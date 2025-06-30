using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Entities;
using BlazorApp1.Context;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryBand : RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context) { }
    }
}
  