using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess
{
	public class CompanyDbContext : DbContext
	{
		public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
			:base(options)
		{ }
		public DbSet<Company> Company { get; set; }
		public DbSet<Employee> Employee { get; set; }
		public DbSet<ShippmentService> ShippmentServices { get; set; }
		public DbSet<DeliveryByDimension> DeliveryByDimensions { get; set; }
		public DbSet<DeliveryByWeight> DeliveryByWeights { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Company>()
				.HasOne<ShippmentService>(x => x.ShippmentService)
				.WithOne(x => x.Company)
				.HasForeignKey<ShippmentService>(x => x.CompanyId);

			modelBuilder.Entity<Company>()
				.HasMany<Employee>(x => x.Employees)
				.WithOne(x => x.Company)
				.HasForeignKey(x => x.CompanyId);
			modelBuilder.Entity<ShippmentService>()
				.HasMany<DeliveryByDimension>(x => x.DeliveryByDimensions)
				.WithOne(x => x.ShippmentService)
				.HasForeignKey(x => x.ShippmentServiceId);
			modelBuilder.Entity<ShippmentService>()
				.HasMany<DeliveryByWeight>(x => x.DeliveryByWeights)
				.WithOne(x => x.ShippmentService)
				.HasForeignKey(x => x.ShippmentServiceId);

		}
	}
}
