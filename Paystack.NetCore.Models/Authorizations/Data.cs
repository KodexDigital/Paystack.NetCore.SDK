using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Authorizations
{
	public class Data
	{
		[JsonProperty(PropertyName = "request_authorization_url")]
		public string RequestAuthorizationUrl{ get; set; }

		[JsonProperty(PropertyName = "reference")]
		public string Reference { get; set; }
	}
}
