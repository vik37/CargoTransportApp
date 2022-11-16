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
	}
}
