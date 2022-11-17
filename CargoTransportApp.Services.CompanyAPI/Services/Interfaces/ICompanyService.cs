using CargoTransportApp.Services.CompanyAPI.Dtos;

namespace CargoTransportApp.Services.CompanyAPI.Services.Interfaces
{
	public interface ICompanyService
	{
		Task<IEnumerable<CompanyDto>> GetAllCompanies();
		Task<CompanyDto> GetCompanyById(int id);
	}
}
