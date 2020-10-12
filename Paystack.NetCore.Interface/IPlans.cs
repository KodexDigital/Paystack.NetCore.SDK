using Paystack.NetCore.Models.Plans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface IPlans
	{
		Task<Plan> CreatePlan(string name, string description, int amount, string interval, bool send_invoices = false,
			   bool send_sms = false, string currency = "NGN", int invoice_limit = 0);

		Task<PlanList> ListPlans();

		Task<FetchPlan> FetchPlans(string plan_code);
	}
}
