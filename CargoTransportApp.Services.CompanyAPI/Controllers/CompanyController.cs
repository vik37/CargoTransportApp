using CargoTransportApp.Services.CompanyAPI.Dtos;
using CargoTransportApp.Services.CompanyAPI.Helper;
using CargoTransportApp.Services.CompanyAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoTransportApp.Services.CompanyAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanyController : ControllerBase
	{
		private readonly ICompanyService _companyService;
		private ResponseDto _respone;
		public CompanyController(ICompanyService companyService)
		{
			_companyService = companyService;
			_respone = new ResponseDto();
		}
		[HttpGet]
		public async Task<ResponseDto> Get()
		{
			var company = await _companyService.GetAllCompanies();
			_respone.Status = StatusCodes.Status200OK;
			_respone.Body = company;
			_respone.IsSuccess = true;
			return _respone;
		}
		[HttpGet("{id}")]
		public async Task<ResponseDto> Get(int id)
		{
			try
			{
				var company = await _companyService.GetCompanyById(id);
				_respone.Status = StatusCodes.Status200OK;
				_respone.Body = company;
				return _respone;
			}
			catch (CompanyException ex)
			{
				_respone.Status = StatusCodes.Status404NotFound;
				_respone.IsSuccess = false;
				_respone.Message = ex.Message;
				return _respone;
			}
			catch (Exception)
			{
				_respone.Status = StatusCodes.Status500InternalServerError;
				_respone.IsSuccess = false;
				_respone.Message = "Server Problem";
				return _respone;
			}
		}
	}
}
