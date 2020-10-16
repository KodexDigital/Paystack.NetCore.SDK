using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Customers
{
	public class ListResponse : Responses
	{
		public List<Data> Data { get; set; }
	}
}
