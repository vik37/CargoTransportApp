using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class DeliveryByWeight : DeliveryByDimension
	{
		public bool ForEvery { get; set; }
		public double ForEveryPrice { get; set; }
		public int ForEveryKg { get; set; }
	}
}
