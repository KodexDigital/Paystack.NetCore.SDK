using System.Collections.Generic;

namespace Paystack.NetCore.Models.Customers
{
	public class ListResponse : Responses
	{
		public List<Data> Data { get; set; }
	}
}
