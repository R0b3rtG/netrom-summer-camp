using Microsoft.VisualBasic;
using BlazorApp1.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Entities
{
    public class Band
    {
		public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public ICollection<Festival> Festivals { get; set; } = [];
    }
}
