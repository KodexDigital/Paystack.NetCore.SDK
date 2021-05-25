using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transactions
{
	public class TransactionTotal : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
