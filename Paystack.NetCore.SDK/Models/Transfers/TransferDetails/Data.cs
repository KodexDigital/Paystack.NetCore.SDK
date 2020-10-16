using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transfers.TransferDetails
{
	public class Data : BaseModel
	{
		[JsonProperty(PropertyName ="domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }

		[JsonProperty(PropertyName = "source")]
		public string Source { get; set; }

		[JsonProperty(PropertyName = "source_details")]
		public object SourceDetails { get; set; }

		[JsonProperty(PropertyName = "reason")]
		public string Reason { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "failures")]
		public object Failures { get; set; }

		[JsonProperty(PropertyName = "transfer_code")]
		public string TransferCode { get; set; }

		[JsonProperty(PropertyName = "recipient")]
		public Recipient Recipient { get; set; }
	}
}
