using System.ComponentModel.DataAnnotations;
using Blazorise;

namespace BlazorApp1.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public int FestivalId { get; set; }
        public Festival? Festival { get; set; }
        public DateTime Date { get; set; }

    }
}
