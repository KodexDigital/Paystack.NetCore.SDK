using System.Collections.Generic;

namespace Paystack.NetCore.Models.Plans
{
	public class Datum : BaseModel
	{
		public int Integration { get; set; }
		public string Domain { get; set; }
		public string Name { get; set; }
		public string PlanCode { get; set; }
		public object Description { get; set; }
		public int Amount { get; set; }
		public string Interval { get; set; }
		public bool SendInvoices { get; set; }
		public bool SendSms { get; set; }
		public bool HostedPage { get; set; }
		public object HostedPageUrl { get; set; }
		public object HostedPageSummary { get; set; }
		public string Currency { get; set; }
		public List<object> Subscriptions { get; set; }
	}
}
