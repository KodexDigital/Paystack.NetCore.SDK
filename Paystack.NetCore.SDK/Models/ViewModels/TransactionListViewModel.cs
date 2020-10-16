using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.ViewModels
{
	public class TransactionListViewModel : Responses
	{
		public List<Data> Datas { get; set; }
	}
}
