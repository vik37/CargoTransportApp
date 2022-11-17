using AutoMapper;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.Dtos;

namespace CargoTransportApp.Services.CompanyAPI.Helper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Company, CompanyDto>()
				.ForMember(x => x.CreatedOn, src => src.Ignore())
				.ForMember(x => x.DeletedOn, src => src.Ignore())
				.ReverseMap()
				.ForMember(x => x.CraetedOn, src => src.Ignore())
				.ForMember(x => x.DeletedOn, src => src.Ignore());
			CreateMap<ShippmentService, ShippmentServiceDto>()
				.ReverseMap();
			CreateMap<DeliveryByDimension, DeliveryByDimensionDto>()
				.ReverseMap();
			CreateMap<DeliveryByWeight, DeliveryByWeightDto>()
				.ReverseMap();
			CreateMap<Employee, EmployeeDto>()
				.ReverseMap();
		}
	}
}
