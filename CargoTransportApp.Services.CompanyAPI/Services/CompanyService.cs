using AutoMapper;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using CargoTransportApp.Services.CompanyAPI.Dtos;
using CargoTransportApp.Services.CompanyAPI.Helper;
using CargoTransportApp.Services.CompanyAPI.Services.Interfaces;

namespace CargoTransportApp.Services.CompanyAPI.Services
{
	public class CompanyService : ICompanyService
	{
		private readonly IRepository<Company> _companyRepository;
		private readonly IMapper _mapper;
		public CompanyService(IRepository<Company> companyResitory,
								IMapper mapper)
		{
			_companyRepository = companyResitory;
			_mapper = mapper;
		}
		public async Task<IEnumerable<CompanyDto>> GetAllCompanies()
		{
			var companies = await _companyRepository.Get();
			return _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyDto>>(companies);
		}

		public async Task<CompanyDto> GetCompanyById(int id)
		{
			try
			{
				var company = await _companyRepository.GetById(id);
				if (company == null)
					throw new CompanyException("Company does not exist");
				return _mapper.Map<CompanyDto>(company);
			}
			catch(CompanyException ex)
			{
				throw new CompanyException(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
