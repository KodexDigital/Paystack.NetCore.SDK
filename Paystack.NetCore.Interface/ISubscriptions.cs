using Paystack.NetCore.Models.Subscriptions;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface ISubscriptions
	{
		Task<Subscription> CreateSubscription(string customerEmail, string planCode, string authorization, string start_date);
	}
}
