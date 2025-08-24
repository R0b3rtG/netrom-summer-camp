using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Blazorise;

namespace BlazorApp1.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public Guid FestivalId { get; set; }
        public Festival? Festival { get; set; }
        public DateTime Date { get; set; }
        [DefaultValue(false)]
        public bool Purchased { get; set; }
        [DefaultValue(false)]
        public bool RefundRequested { get; set; }

    }
}
