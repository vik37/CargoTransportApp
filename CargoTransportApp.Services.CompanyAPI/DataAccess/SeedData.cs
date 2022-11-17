using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess
{
	public static class SeedData
	{
		public static void Seed(ModelBuilder builder)
		{
			builder.Entity<Company>()
				.HasData(
					new Company
					{
						Id= 1,
						Name= "Cargo for you",
						CompanyRegisterKey = "9ffa2d7e-9d46-4a70-a810-f1838aefa876",
						Address = "Green Street 12A",
						PostCode = 3698,
						City = "London",
						Country = "United Kingdom",
						Link = "foryou.com",
						CompanyRole = CompanyRole.Host
					},
					new Company
					{
						Id = 2,
						Name = "Ship faster",
						CompanyRegisterKey = "ff3f4d99-4948-41b7-bbbe-2e9912967f77",
						Address = "bul. ASNOM 23",
						PostCode = 1000,
						City = "Skopje",
						Country = "Macedonia",
						Link = "shipfaster.com.mk",
						CompanyRole = CompanyRole.Partner,
						CraetedOn = "28/02/2016"
					},
					new Company
					{
						Id = 3,
						Name = "Malta ship",
						CompanyRegisterKey = "9cb254cb-2c83-41bc-a75b-f73733060946",
						Address = "Lascaris Wharf 239A",
						PostCode = 1118,
						City = "La Valleta",
						Country = "Malta",
						Link = "https://www.visitmalta.com/en/info/valletta-malta/",
						CompanyRole = CompanyRole.Partner,
						CraetedOn = "04/19/2005"
					}
				);

			builder.Entity<Employee>()
				.HasData(
					new Employee
					{
						Id = "d7475312-f64d-42ee-8a1e-96d989a77bae",
						Firstname = "Adam",
						Lastname = "Stalone",
						Email = "adam@gmail.com",
						WorkPosition = "Manager",
						CompanyId = 1
					}
				);
			builder.Entity<ShippmentService>()
				.HasData(
					new ShippmentService
					{
						Id = 1,
						Parcel = 36,
						MaximumDefaultDimension = 2000,
						MaximumDefaultWeight = 20,
						InitialDimensionPrice = 10,
						InitialWeightPrice = 15,
						CompanyId = 1
					},
					new ShippmentService
					{
						Id = 2,
						Parcel = 18,
						MinimumDefaultWeight = 10,
						MaximumDefaultWeight = 30,
						MaximumDefaultDimension = 1700,
						InitialDimensionPrice = 11.99,
						InitialWeightPrice = 16.50,
						CompanyId = 2
					},
					new ShippmentService
					{
						Id = 3,
						Parcel = 26,
						MinimumDefaultWeight = 10,
						MinimumDefaultDimension = 500,
						InitialDimensionPrice = 9.50,
						InitialWeightPrice = 16.99,
						CompanyId = 3
					}
				);
			builder.Entity<DeliveryByDimension>()
				.HasData(
					new DeliveryByDimension
					{
						Id = 1,
						Less = 1000,
						ShippmentServiceId = 1
					},
					new DeliveryByDimension
					{
						Id = 2,
						PriceIncrease = 10,
						Less = 2000,
						Bigger = 1000,
						ShippmentServiceId = 1
					},
					new DeliveryByDimension
					{
						Id = 3,
						Less = 1000,
						ShippmentServiceId = 2
					},
					new DeliveryByDimension
					{
						Id = 4,
						PriceIncrease = 10,
						Bigger = 1000,
						Less = 1700,
						ShippmentServiceId = 2
					},
					new DeliveryByDimension
					{
						Id = 5,
						Less = 1000,
						ShippmentServiceId = 3
					},
					new DeliveryByDimension
					{
						Id = 6,
						PriceIncrease = 10,
						Less = 2000,
						Bigger = 1000,
						ShippmentServiceId = 3
					},
					new DeliveryByDimension
					{
						Id = 7,
						PriceIncrease = 29,
						Less = 5000,
						Bigger = 2000,
						ShippmentServiceId = 3
					}
				);
			builder.Entity<DeliveryByWeight>()
				.HasData(
					new DeliveryByWeight
					{
						Id = 1,
						Less = 2,
						ForEvery = false,
						ShippmentServiceId = 1
					},
					new DeliveryByWeight
					{
						Id = 2,
						PriceIncrease = 3,
						Less = 15,
						Bigger = 2,
						ForEvery = false,
						ShippmentServiceId = 1
					},
					new DeliveryByWeight
					{
						Id = 3,
						PriceIncrease = 17,
						Less = 20,
						Bigger = 15,
						ForEvery = false,
						ShippmentServiceId = 1
					},
					new DeliveryByWeight
					{
						Id = 4,
						Less = 15,
						Bigger = 10,
						ForEvery = false,
						ShippmentServiceId = 2
					},
					new DeliveryByWeight
					{
						Id = 5,
						PriceIncrease = 20,
						Bigger = 15,
						Less = 25,
						ForEvery = false,
						ShippmentServiceId = 2
					},
					new DeliveryByWeight
					{
						Id = 6,
						PriceIncrease = 3.5,
						Bigger = 25,
						ForEvery = true,
						ForEveryKg = 1,
						ForEveryPrice = 0.417,
						ShippmentServiceId = 2
					},
					new DeliveryByWeight
					{
						Id = 7,
						Less = 20,
						Bigger = 10,
						ForEvery = false,
						ShippmentServiceId = 3
					},
					new DeliveryByWeight
					{
						Id = 8,
						PriceIncrease = 17,
						Less = 30,
						Bigger = 20,
						ForEvery = false,
						ShippmentServiceId = 3
					},
					new DeliveryByWeight
					{
						Id = 9,
						PriceIncrease = 10,
						Bigger = 30,
						ForEvery = true,
						ForEveryPrice = 0.41,
						ForEveryKg = 1,
						ShippmentServiceId = 3
					}
				);
		}
	}
}
