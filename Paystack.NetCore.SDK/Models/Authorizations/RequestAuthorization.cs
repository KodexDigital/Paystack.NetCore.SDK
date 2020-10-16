using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Authorizations
{
	public class RequestAuthorization : Responses
	{
		[JsonProperty(PropertyName ="data")]
		public Data Data { get; set; }
	}
}
