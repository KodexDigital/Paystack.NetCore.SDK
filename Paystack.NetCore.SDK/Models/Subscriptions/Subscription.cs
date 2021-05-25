using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Subscriptions
{
	public class Subscription : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
