using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class Company : Deleted
	{
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		public string CompanyRegisterKey { get; set; } = string.Empty;
		[Required]
		public string Address { get; set; } = string.Empty;
		[Required]
		public int PostCode { get; set; }
		[Required]
		public string City { get; set; } = string.Empty;
		[Required]
		public string Country { get; set; } = string.Empty;
		[Required]
		public CompanyRole CompanyRole { get; set; }
		public ShippmentService ShippmentService { get; set; }
		public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
		
	}
}
