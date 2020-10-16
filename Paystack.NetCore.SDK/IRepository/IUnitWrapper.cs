using Paystack.NetCore.SDK.Interfaces;

namespace Paystack.NetCore.SDK.IRepository
{
	public interface IUnitWrapper
	{
		ICharge CardCharge { get; set; }
	}
}
