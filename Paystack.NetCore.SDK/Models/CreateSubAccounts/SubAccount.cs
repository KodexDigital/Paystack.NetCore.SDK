using Paystack.NetCore.SDK.Models.CreateSubAccounts;

namespace Paystack.NetCore.SDK.Models.SubAccounts
{
	public class SubAccount : Responses
	{
		public CreateSubAccounts.Data Data { get; set; }
	}
}
