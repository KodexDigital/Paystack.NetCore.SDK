using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Plans
{
	public class FetchPlan : Responses
	{
		[JsonProperty(PropertyName = "datum")]
		public Datum Datum { get; set; }
	}
}
