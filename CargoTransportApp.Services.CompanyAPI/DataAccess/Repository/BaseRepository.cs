namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository
{
	public class BaseRepository
	{
		protected readonly CompanyDbContext _db;
		public BaseRepository(CompanyDbContext db)
		{
			_db = db;
		}
	}
}
