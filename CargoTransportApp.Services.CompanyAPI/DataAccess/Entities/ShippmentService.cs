using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class ShippmentService : BaseId
	{
		public int Parcel { get; set; }
		public int? MinimumDefaultDimension { get; set; }
		public int? MaximumDefaultDimension { get; set; }
		public int? MinimumDefaultWeight { get; set; }
		public int? MaximumDefaultWeight { get; set; }
		public double InitialDimensionPrice { get; set; }
		public double InitialWeightPrice { get; set; }
		public int CompanyId { get; set; }
		public Company Company { get; set; }
		public IEnumerable<DeliveryByDimension> DeliveryByDimensions { get; set; } = new List<DeliveryByDimension>();
		public IEnumerable<DeliveryByWeight> DeliveryByWeights { get; set; } = new List<DeliveryByWeight>();
	}
}
