using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Customers
{
	public class ListResponse : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public List<Data> Data { get; set; }
	}
}
