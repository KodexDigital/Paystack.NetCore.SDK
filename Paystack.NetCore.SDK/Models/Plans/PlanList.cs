using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Plans
{
	public class PlanList : Responses
	{
		[JsonProperty(PropertyName = "datums")]
		public List<Datum> Datums { get; set; }
	}
}
