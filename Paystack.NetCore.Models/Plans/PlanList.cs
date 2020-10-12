using System.Collections.Generic;

namespace Paystack.NetCore.Models.Plans
{
	public class PlanList : Responses
	{
		public List<Datum> Datums { get; set; }
	}
}
