using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository
{
	public class ShippmentServiceRepository : BaseRepository, IRepository<ShippmentService>
	{
		public ShippmentServiceRepository(CompanyDbContext db) : base(db) { }
		public async Task<IEnumerable<ShippmentService>> Get()
		{
			return await _db.ShippmentServices.Include(x => x.DeliveryByDimensions)
										.Include(x => x.DeliveryByWeights)
										.ToListAsync();
		}
		public async Task<ShippmentService> GetById(int id)
		{
			return await _db.ShippmentServices.Include(x => x.DeliveryByDimensions)
										.Include(x => x.DeliveryByWeights)
										.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<int> Add(ShippmentService entity)
		{
			if (entity == null)
				return -1;
			_db.ShippmentServices.Add(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Update(ShippmentService entity)
		{
			if(entity == null)
				return -1;
			_db.ShippmentServices.Update(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Delete(int id)
		{
			var shippment = await _db.ShippmentServices.FirstOrDefaultAsync(x => x.Id == id);
			if (shippment == null)
				return -1;
			_db.ShippmentServices.Remove(shippment); 
			return await _db.SaveChangesAsync();
		}		
	}
}
