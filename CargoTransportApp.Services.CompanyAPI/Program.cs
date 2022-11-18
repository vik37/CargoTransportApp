using CargoTransportApp.Services.CompanyAPI.DataAccess;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using CargoTransportApp.Services.CompanyAPI.Services;
using CargoTransportApp.Services.CompanyAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
IConfiguration configuration = builder.Configuration;

// Add services to the container.

services.AddControllers()
	.AddNewtonsoftJson(opt => 
		opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
	.AddNewtonsoftJson(opt => 
		opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<CompanyDbContext>(opt =>
		opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
		options => options.MigrationsAssembly("CargoTransportApp.Services.CompanyAPI")));

services.AddTransient<IRepository<Company>, CompanyRepository>();
services.AddTransient<IRepository<ShippmentService>, ShippmentServiceRepository>();
services.AddTransient<IRepository<DeliveryByDimension>, DeliveryByDimensionRepository>();
services.AddTransient<IRepository<DeliveryByWeight>, DeliveryByWeightRepository>();

services.AddTransient<ICompanyService, CompanyService>();

services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

services.AddCors(opt =>
{
	opt.AddDefaultPolicy(builder =>
	{
		builder.AllowAnyOrigin()
				.AllowAnyHeader()
				.AllowAnyMethod();
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
