using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Verifications
{
	public class BvnData
	{
		[JsonProperty(PropertyName = "first_name")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "dob")]
		public string DOB { get; set; }

		[JsonProperty(PropertyName = "mobile")]
		public string Mobile { get; set; }

		[JsonProperty(PropertyName = "bvn")]
		public string BVN { get; set; }
	}
}
