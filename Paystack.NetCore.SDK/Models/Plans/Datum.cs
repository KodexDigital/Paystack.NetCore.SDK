using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Plans
{
	public class Datum : BaseModel
	{
		[JsonProperty(PropertyName = "intergration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "plan_code")]
		public string PlanCode { get; set; }

		[JsonProperty(PropertyName = "description")]
		public object Description { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "interval")]
		public string Interval { get; set; }

		[JsonProperty(PropertyName = "send_invoices")]
		public bool SendInvoices { get; set; }

		[JsonProperty(PropertyName = "send_sms")]
		public bool SendSms { get; set; }

		[JsonProperty(PropertyName = "hosted_page")]
		public bool HostedPage { get; set; }

		[JsonProperty(PropertyName = "Hosted_page_url")]
		public object HostedPageUrl { get; set; }

		[JsonProperty(PropertyName = "hosted_page_summary")]
		public object HostedPageSummary { get; set; }

		[JsonProperty(PropertyName = "currency")]
		public string Currency { get; set; }

		[JsonProperty(PropertyName = "subscriptions")]
		public List<object> Subscriptions { get; set; }
	}
}
