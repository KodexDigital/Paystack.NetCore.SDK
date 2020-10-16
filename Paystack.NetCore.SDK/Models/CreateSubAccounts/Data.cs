using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.CreateSubAccounts
{
	public class Data : BaseModel
	{
		[JsonProperty(PropertyName = "integration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "subaccount_code")]
		public string SubaccountCode { get; set; }

		[JsonProperty(PropertyName = "business_name")]
		public string BusinessName { get; set; }

		[JsonProperty(PropertyName = "description")]
		public object Description { get; set; }

		[JsonProperty(PropertyName = "primary_contact_name")]
		public object PrimaryContactName { get; set; }

		[JsonProperty(PropertyName = "primary_contact_email")]
		public object PrimaryContactEmail { get; set; }

		[JsonProperty(PropertyName = "primary_contact_phone")]
		public object PrimaryContactPhone { get; set; }

		[JsonProperty(PropertyName = "metadata")]
		public object Metadata { get; set; }

		[JsonProperty(PropertyName = "percentage_charge")]
		public double PercentageCharge { get; set; }

		[JsonProperty(PropertyName = "is_verified")]
		public bool IsVerified { get; set; }

		[JsonProperty(PropertyName = "settlement_bank")]
		public string SettlementBank { get; set; }

		[JsonProperty(PropertyName = "account_number")]
		public string AccountNumber { get; set; }

		[JsonProperty(PropertyName = "settlement_schedule")]
		public string SettlementSchedule { get; set; }

		[JsonProperty(PropertyName = "active")]
		public bool Active { get; set; }

		[JsonProperty(PropertyName = "migrate")]
		public bool Migrate { get; set; }
	}
}
