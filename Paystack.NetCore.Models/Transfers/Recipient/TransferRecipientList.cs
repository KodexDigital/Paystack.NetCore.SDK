using System.Collections.Generic;
namespace Paystack.NetCore.Models.Transfers.Recipient
{
	public class TransferRecipientList : Responses
	{
		public List<Data> Datas { get; set; }
	}
}
