using System;
namespace Paystack.NetCore.Models.Transactions
{
	public class TotalVolumeByCurrency
	{
		public string Currency { get; set; }
		public int Amount { get; set; }
	}
}
