using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository
{
	public class DeliveryByDimensionRepository : BaseRepository, IRepository<DeliveryByDimension>
	{
		public DeliveryByDimensionRepository(CompanyDbContext db) : base(db) { }
		public async Task<IEnumerable<DeliveryByDimension>> Get()
		{
			return await _db.DeliveryByDimensions.ToListAsync();
		}
		public async Task<DeliveryByDimension> GetById(int id)
		{
			return await _db.DeliveryByDimensions.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<int> Add(DeliveryByDimension entity)
		{
			if (entity == null)
				return -1;
			_db.DeliveryByDimensions.Add(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Update(DeliveryByDimension entity)
		{
			if(entity == null) 
				return -1;
			_db.DeliveryByDimensions.Update(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Delete(int id)
		{
			var dimension = await _db.DeliveryByDimensions.FirstOrDefaultAsync(x => x.Id == id);
			if (dimension == null)
				return -1;
			_db.DeliveryByDimensions.Remove(dimension);
			return await _db.SaveChangesAsync();
		}		
	}
}
