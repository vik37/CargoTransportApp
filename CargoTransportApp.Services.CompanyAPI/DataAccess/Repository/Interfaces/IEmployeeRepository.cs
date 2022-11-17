using CargoTransportApp.Services.CompanyAPI.DataAccess.Entities;

namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Repository.Interfaces
{
	public interface IEmployeeRepository
	{
		Task<Employee> GetEmployeeById(string id);
		Task<int> AddEmployee(Employee employee);
		Task<int> DeleteEmployee(Employee employee);
	}
}
