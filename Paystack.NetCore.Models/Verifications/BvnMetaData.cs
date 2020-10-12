using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Verifications
{
	public class BvnMetaData
	{
		[JsonProperty(PropertyName = "calls_this_month")]
		public int CallsThisMonth { get; set; }

		[JsonProperty(PropertyName = "free_calls_left")]
		public int FreeCallsLeft { get; set; }
	}
}
