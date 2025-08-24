using System.ComponentModel.DataAnnotations;
using Blazorise.DeepCloner;
using Microsoft.VisualBasic;

namespace BlazorApp1.Entities
{
	public class DateNotInPastAttribute : ValidationAttribute
	{
		public override bool IsValid(object? value)
		{
			if (value is DateTime date)
			{
				return date.Date >= DateTime.Today;
			}

			return true; // Let [Required] handle null if necessary
		}

		public override string FormatErrorMessage(string name)
		{
			return $"{name} cannot be in the past.";
		}
	}

	public class DateGreaterThanAttribute : ValidationAttribute
	{
		private readonly string _comparisonProperty;

		public DateGreaterThanAttribute(string comparisonProperty)
		{
			_comparisonProperty = comparisonProperty;
		}

		protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
		{
			var currentValue = (DateTime?)value;

			var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
			if (property == null)
				return new ValidationResult($"Unknown property: {_comparisonProperty}");

			var comparisonValue = (DateTime?)property.GetValue(validationContext.ObjectInstance);

			if (currentValue < comparisonValue)
			{
				return new ValidationResult("End date must be after start date.", new[] { validationContext.MemberName! });

			}

			return ValidationResult.Success!;
		}
	}

	public class Festival
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required(ErrorMessage = "The Start Date field is required.")]
		[DateNotInPast(ErrorMessage = "Start date cannot be in the past.")]
        public DateTime? StartDate { get; set; }
        [Required(ErrorMessage = "The End Date field is required.")]
		[DateNotInPast(ErrorMessage = "End date cannot be in the past.")]
		[DateGreaterThan(nameof(StartDate), ErrorMessage = "End date cannot be earlier than start date.")]
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "The Image field is required.")]
		public byte[]? ImageData { get; set; }
        [Required]
		public string? ImageMimeType { get; set; }
		public ICollection<FestivalBand> FestivalBands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        [Required]
		[Range(0, int.MaxValue, ErrorMessage = "Price must not be negative.")]
		public float Price { get; set; }
	}
}
