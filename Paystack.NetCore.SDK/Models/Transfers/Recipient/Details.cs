using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transfers.Recipient
{
	public class Details
	{
		[JsonProperty(PropertyName = "account_number")]
		public string AccountNumber { get; set; }

		[JsonProperty(PropertyName = "account_name")]
		public object AccountName { get; set; }

		[JsonProperty(PropertyName = "bank_code")]
		public string BankCode { get; set; }

		[JsonProperty(PropertyName = "bank_name")]
		public string BankName { get; set; }
	}
}
