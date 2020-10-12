using Newtonsoft.Json;
using System;

namespace Paystack.NetCore.Models
{
	public class TransactionInitializationRequest
	{
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "subaccount")]
		public string Subaccount { get; set; }

		[JsonProperty(PropertyName = "transaction_charge")]
		public Int32 TransactionCharge { get; set; } = 0;

		[JsonProperty(PropertyName = "bearer")]
		public string Bearer { get; set; } = "account";

		[JsonProperty(PropertyName = "first_name")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "callback_url")]
		public string CallbackUrl { get; set; }

		[JsonProperty(PropertyName = "reference")]
		public string Reference { get; set; }

		[JsonProperty(PropertyName = "plan")]
		public string Plan { get; set; }

		[JsonProperty(PropertyName = "invoice_limit")]
		public Int32 InvoiceLimit { get; set; } = 0;

		[JsonProperty(PropertyName = "make_reference_unique")]
		public bool MakeReferenceUnique { get; set; } = false;
	}
}
