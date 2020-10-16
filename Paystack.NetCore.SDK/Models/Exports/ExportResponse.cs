using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Exports
{
	public class ExportResponse : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public Data Data { get; set; }
	}
}
