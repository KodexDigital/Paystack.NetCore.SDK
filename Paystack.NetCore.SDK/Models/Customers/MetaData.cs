using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Customers
{
	public class MetaData
	{
		[JsonProperty(PropertyName = "photos")]
		public List<Photo> Photos { get; set; }
	}
}
