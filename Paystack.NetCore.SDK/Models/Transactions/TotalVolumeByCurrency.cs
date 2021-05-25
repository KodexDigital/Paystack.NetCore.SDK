using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transactions
{
	public class TotalVolumeByCurrency
	{
		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public int Amount { get; set; }
	}
}
