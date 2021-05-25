using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.SubAccounts
{
	public class SubAccount : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public CreateSubAccounts.Data Data { get; set; }
	}
}
