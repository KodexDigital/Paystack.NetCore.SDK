using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Charges
{
	public class ChargeAuthorizationInput
	{
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		[JsonProperty(PropertyName = "amount")]
		public string Amount { get; set; }

		[JsonProperty(PropertyName = "metadata")]
		public Metadata MetaData { get; set; }

		[JsonProperty(PropertyName = "authorization_code")]
		public string AuthorizationCode { get; set; }

		[JsonProperty(PropertyName = "pin")]
		public string Pin { get; set; }
	}
	public class AuthCustomField
	{
		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }

		[JsonProperty(PropertyName = "display_name")]
		public string DisplayName { get; set; }

		[JsonProperty(PropertyName = "variable_name")]
		public string VariableName { get; set; }
	}

	public class Metadata
	{
		public List<AuthCustomField> CustomFields { get; set; }
	}
}
