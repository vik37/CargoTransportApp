namespace CargoTransportApp.Services.CompanyAPI.DataAccess.Entities.Base
{
	public class Deleted : Created
	{
		public string DeletedOn { get; set; } = string.Empty;
	}
}
