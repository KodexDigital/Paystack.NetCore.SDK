using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models
{
	public class Responses
	{

		[JsonProperty(PropertyName = "status")]
		public bool Status { get; set; }

		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }
	}
}
