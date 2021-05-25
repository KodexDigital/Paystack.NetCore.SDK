using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transfers.Recipient
{
	public class MetaData
	{
		[JsonProperty(PropertyName = "job")]
		public string Job { get; set; }
	}
}
