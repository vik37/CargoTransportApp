using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;

namespace CargoTransportApp.Services.CompanyAPI.Dtos
{
	public class ShippmentServiceDto
	{
		public int Id { get; set; }
		public int Parcel { get; set; }
		public int? MinimumDefaultDimension { get; set; }
		public int? MaximumDefaultDimension { get; set; }
		public int? MinimumDefaultWeight { get; set; }
		public int? MaximumDefaultWeight { get; set; }
		public double InitialDimensionPrice { get; set; }
		public double InitialWeightPrice { get; set; }
		public int CompanyId { get; set; }
		public Company Company { get; set; }
		public IEnumerable<DeliveryByDimensionDto> DeliveryByDimensions { get; set; } = new List<DeliveryByDimensionDto>();
		public IEnumerable<DeliveryByWeightDto> DeliveryByWeights { get; set; } = new List<DeliveryByWeightDto>();
	}
}
