using Paystack.NetCore.Models.CreateSubAccounts;

namespace Paystack.NetCore.Models.SubAccounts
{
	public class SubAccount : Responses
	{
		public CreateSubAccounts.Data Data { get; set; }
	}
}
