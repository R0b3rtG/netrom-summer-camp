using System.ComponentModel.DataAnnotations;
using BlazorApp1.Enums;

namespace BlazorApp1.Entities
{
    public class Band
    {
		public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "The Image field is required.")]
		public byte[]? ImageData { get; set; }
        [Required]
		public string? ImageMimeType { get; set; }
		public ICollection<FestivalBand> FestivalBands { get; set; } = [];
    }
}
