using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Transfers.Recipient
{
	public class TransferRecipient :Responses 
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
