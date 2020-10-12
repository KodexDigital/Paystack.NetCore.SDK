using System.Collections.Generic;

namespace Paystack.NetCore.Models.Transfers.TransferDetails
{
	public class TransferDetailList : Responses
	{
		public List<Data> Datas { get; set; }
	}
}
