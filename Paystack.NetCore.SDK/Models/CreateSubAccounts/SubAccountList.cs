using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.CreateSubAccounts
{
	public class SubAccountList : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public List<Data> Datas { get; set; }
	}
}
