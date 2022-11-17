namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces
{
	public interface IRepository<T>
	{
		Task<IEnumerable<T>> Get();
		Task<T> GetById(int id);
		Task<int> Add(T entity);
		Task<int> Update(T entity);
		Task<int> Delete(int id);
	}
}
