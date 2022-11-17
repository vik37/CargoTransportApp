using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class DeliveryByDimension : BaseId
	{
		public double? PriceIncrease { get; set; }
		public int? From { get; set; }
		public int? To { get; set; }
		public ComparationSymbol ComparationSymbol { get; set; }		
		[Required]
		public int CompanyId { get; set; }
		public Company Company { get; set; }
		[Required]
		public int ShippmentServiceId { get; set; }
		public ShippmentService ShippmentService { get; set; }
	}
}
