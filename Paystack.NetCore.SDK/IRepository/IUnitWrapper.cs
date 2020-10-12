using Paystack.NetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paystack.NetCore.SDK.IRepository
{
	public interface IUnitWrapper
	{
		ICharge CardCharge { get; set; }
	}
}
