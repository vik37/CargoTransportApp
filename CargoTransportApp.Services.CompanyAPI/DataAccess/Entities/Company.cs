using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities
{
	public class Company : Deleted
	{
		public string Name { get; set; } = string.Empty;
		public string CompanyRegisterKey { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public int PostCode { get; set; }
		public string City { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public CompanyRole CompanyRole { get; set; }
		public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
	}
}
