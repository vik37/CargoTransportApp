using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository
{
	public class DeliveryByWeightRepository : BaseRepository, IRepository<DeliveryByWeight>
	{
		public DeliveryByWeightRepository(CompanyDbContext db) : base(db) { }
		public async Task<IEnumerable<DeliveryByWeight>> Get()
		{
			return await _db.DeliveryByWeights.ToListAsync();
		}
		public async Task<DeliveryByWeight> GetById(int id)
		{
			return await _db.DeliveryByWeights.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<int> Add(DeliveryByWeight entity)
		{
			if (entity == null)
				return -1;
			_db.DeliveryByWeights.Add(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Update(DeliveryByWeight entity)
		{
			if (entity == null)
				return -1;
			_db.DeliveryByWeights.Update(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Delete(int id)
		{
			var weight = await _db.DeliveryByWeights.FirstOrDefaultAsync(x => x.Id == id);
			if (weight == null)
				return -1;
			_db.DeliveryByWeights.Remove(weight);
			return await _db.SaveChangesAsync();
		}		
	}
}
