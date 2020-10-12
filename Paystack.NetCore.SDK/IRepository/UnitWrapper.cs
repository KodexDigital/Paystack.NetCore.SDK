using Paystack.NetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paystack.NetCore.SDK.IRepository
{
	public class UnitWrapper : IUnitWrapper
	{
		public ICharge CardCharge { get; set; }
	}
}
