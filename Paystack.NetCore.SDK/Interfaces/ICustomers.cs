using Paystack.NetCore.SDK.Models.Customers;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface ICustomers
	{
		Task<CreationResponse> CreateCustomer(string email, string firstname = null, string lastname = null, string phone = null);
		Task<ListResponse> ListCustomers();
		Task<CreationResponse> FetchCustomer(int id);
	}
}
