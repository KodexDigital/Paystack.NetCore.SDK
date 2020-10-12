using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Transfers.Recipient
{
	public class Data : BaseModel
	{

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "metadata")]
		public MetaData MetaData { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "metails")]
		public Details Metails { get; set; }

		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }

		[JsonProperty(PropertyName = "account_number")]
		public string AccountNumber { get; set; }

		[JsonProperty(PropertyName = "bank_code")]
		public string BanKCode { get; set; }

		[JsonProperty(PropertyName = "recipient_code")]
		public string RecipientCode { get; set; }

		[JsonProperty(PropertyName = "active")]
		public bool Active { get; set; }
	}
}
