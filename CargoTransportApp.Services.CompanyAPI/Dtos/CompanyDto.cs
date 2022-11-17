
using CargoTransportApp.Services.CompanyAPI.Dtos.Enums;

namespace CargoTransportApp.Services.CompanyAPI.Dtos
{
	public class CompanyDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string CompanyRegisterKey { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public int PostCode { get; set; }
		public string City { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public string Link { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime DeletedOn { get; set; }
		public CompanyRole CompanyRole { get; set; } = CompanyRole.Partner;
		public ShippmentServiceDto ShippmentService { get; set; }
		public IEnumerable<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
	}
}
