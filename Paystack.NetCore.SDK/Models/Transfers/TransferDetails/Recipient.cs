using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transfers.TransferDetails
{
	public class Recipient : BaseModel
	{
		[JsonProperty(PropertyName = "integration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "details")]
		public Details Details { get; set; }

		[JsonProperty(PropertyName = "metadata")]
		public object Metadata { get; set; }

		[JsonProperty(PropertyName = "recipient_code")]
		public string RecipientCode { get; set; }

		[JsonProperty(PropertyName = "active")]
		public bool Active { get; set; }
	}
}
