using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Plans
{
	public class Plan : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
