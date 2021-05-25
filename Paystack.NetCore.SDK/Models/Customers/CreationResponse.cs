using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Customers
{
	public class CreationResponse : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
