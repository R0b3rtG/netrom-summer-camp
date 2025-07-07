using Microsoft.VisualBasic;

namespace BlazorApp1.Entities
{
    public class Festival
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<FestivalBand> FestivalBands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
