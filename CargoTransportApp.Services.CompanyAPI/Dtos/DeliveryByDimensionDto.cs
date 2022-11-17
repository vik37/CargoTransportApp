
namespace CargoTransportApp.Services.CompanyAPI.Dtos
{
	public class DeliveryByDimensionDto
	{
		public int Id { get; set; }
		public double? PriceIncrease { get; set; }
		public int? Less { get; set; }
		public int? Bigger { get; set; }
		public int ShippmentServiceId { get; set; }
		public ShippmentServiceDto ShippmentService { get; set; }
	}
}
