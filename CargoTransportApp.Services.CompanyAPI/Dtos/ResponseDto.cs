﻿namespace CargoTransportApp.Services.CompanyAPI.Dtos
{
	public class ResponseDto
	{
		public bool IsSuccess { get; set; } = true;
		public object Body { get; set; } = null;
		public string Messages { get; set; }
		public int Status { get; set; }
	}
}
