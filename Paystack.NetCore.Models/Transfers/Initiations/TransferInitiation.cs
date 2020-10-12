using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Transfers.Initiations
{
	public class TransferInitiation : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
