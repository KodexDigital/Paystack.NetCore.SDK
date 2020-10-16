
using Paystack.NetCore.SDK.Interfaces;

namespace Paystack.NetCore.SDK.IRepository
{
	public class UnitWrapper : IUnitWrapper
	{
		public ICharge CardCharge { get; set; }
	}
}
