namespace BlazorApp1.Entities
{
	public class FestivalBand
	{
		public Guid FestivalId { get; set; }
		public Guid BandId { get; set; }
		public Band? Band { get; set; }
		public Festival? Festival { get; set; }
		public int Order { get; set; }
	}
}
