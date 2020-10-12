using Newtonsoft.Json;

namespace Paystack.NetCore.Models
{
	public class SubData
	{
		[JsonProperty(PropertyName ="authorization_url")]
		public string AuthorizationUrl { get; set; }

		[JsonProperty(PropertyName = "access_code")]
		public string AccessCode { get; set; }

		[JsonProperty(PropertyName = "reference")]
		public string Reference { get; set; }
	}
}
