
using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Plans
{
	public class Data : BaseModel
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "mount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "interval")]
		public string Interval { get; set; }

		[JsonProperty(PropertyName = "integration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "plan_code")]
		public string PlanCode { get; set; }

		[JsonProperty(PropertyName = "send_invoices")]
		public bool SendInvoices { get; set; }

		[JsonProperty(PropertyName = "send_sms")]
		public bool SendSms { get; set; }

		[JsonProperty(PropertyName = "hosted_page")]
		public bool HostedPage { get; set; }

		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }
	}
}
