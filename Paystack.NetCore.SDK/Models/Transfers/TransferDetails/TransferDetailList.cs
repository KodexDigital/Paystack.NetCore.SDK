using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Transfers.TransferDetails
{
	public class TransferDetailList : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public List<Data> Datas { get; set; }
	}
}
