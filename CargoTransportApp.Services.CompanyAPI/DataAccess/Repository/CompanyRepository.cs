using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;
using CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository
{
	public class CompanyRepository : BaseRepository, IRepository<Company>
	{
		public CompanyRepository(CompanyDbContext db):base(db) { }

		public async Task<IEnumerable<Company>> Get()
		{
			return await _db.Company.ToListAsync();
								
		}
		public async Task<Company> GetById(int id)
		{
			return await _db.Company.Include(x => x.ShippmentService)
									.ThenInclude(x => x.DeliveryByDimensions)
								.Include(x => x.ShippmentService)
									.ThenInclude(x => x.DeliveryByWeights)
								.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<int> Add(Company entity)
		{
			if (entity != null)
				_db.Company.Add(entity);
			else return -1;

			return await _db.SaveChangesAsync();
			
		}
		public async Task<int> Update(Company entity)
		{
			if(entity == null)
				return -1;
			_db.Company.Update(entity);
			return await _db.SaveChangesAsync();
		}
		public async Task<int> Delete(int id)
		{
			var company = await _db.Company.FirstOrDefaultAsync(x => x.Id == id);
			if (company == null)
				return -1;
			_db.Company.Remove(company);
			return await _db.SaveChangesAsync();
		}		
	}
}
