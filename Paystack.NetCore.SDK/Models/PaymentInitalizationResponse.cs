using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models
{
	public class PaymentInitalizationResponse : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public SubData SubData { get; set; }
	}
}
