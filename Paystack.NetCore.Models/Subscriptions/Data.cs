using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Subscriptions
{
	public class Data : BaseModel
	{
		[JsonProperty(PropertyName = "customer")]
		public int Customer { get; set; }

		[JsonProperty(PropertyName = "plan")]
		public int Plan { get; set; }

		[JsonProperty(PropertyName = "integration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "start")]
		public int Start { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "quantity")]
		public int Quantity { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "authorization")]
		public int Authorization { get; set; }

		[JsonProperty(PropertyName = "subscription_code")]
		public string SubscriptionCode { get; set; }

		[JsonProperty(PropertyName = "email_token")]
		public string EmailToken { get; set; }
	}
}
