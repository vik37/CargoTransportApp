
namespace CargoTransportApp.Services.CompanyAPI.Dtos
{
	public class EmployeeDto
	{
		public string Id { get; set; } = string.Empty;
		public string Firstname { get; set; } = string.Empty;
		public string Lastname { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string WorkPosition { get; set; } = string.Empty;
		public int CompanyId { get; set; }
		public CompanyDto Company { get; set; }
	}
}
