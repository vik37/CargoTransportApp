using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class DeliveryByWeight :BaseId
	{
		public double? PriceIncrease { get; set; }
		public int? Less { get; set; }
		public int? Bigger { get; set; }
		[Required]
		public int ShippmentServiceId { get; set; }
		public ShippmentService ShippmentService { get; set; }
		public bool ForEvery { get; set; }
		public double ForEveryPrice { get; set; }
		public int ForEveryKg { get; set; }
	}
}
