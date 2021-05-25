using Newtonsoft.Json;
using System.Collections.Generic;
namespace Paystack.NetCore.SDK.Models.Transfers.Recipient
{
	public class TransferRecipientList : Responses
	{
		[JsonProperty(PropertyName = "data")]
		public List<Data> Datas { get; set; }
	}
}
