using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Paystack.NetCore.Models.Customers
{
	public class Data : BaseModel
	{
		[JsonProperty(PropertyName = "integration")]
		public int Integration { get; set; }

		[JsonProperty(PropertyName = "first_name")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		[JsonProperty(PropertyName = "phone")]
		public object Phone { get; set; }

		[JsonProperty(PropertyName = "metadata")]
		public MetaData MetaData { get; set; }

		[JsonProperty(PropertyName = "domain")]
		public string Domain { get; set; }

		[JsonProperty(PropertyName = "customer_code")]
		public string CustomerCode { get; set; }

		[JsonProperty(PropertyName = "risk_action")]
		public string RiskAction { get; set; }
	}
}
