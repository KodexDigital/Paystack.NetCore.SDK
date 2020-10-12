using Paystack.NetCore.Models.Charges;
using System.Threading.Tasks;

namespace Paystack.NetCore.Interfaces
{
	public interface ICharge
	{
		Task<ChargeResponse> ChargeCard(string email, string amount, string pin, string cvv,
			   string expiry_month, string expiry_year, string number, string display_name = null, string value = null,
			   string variable_name = null);

		Task<ChargeResponse> SubmitPin(string pin, string reference);

		Task<ChargeResponse> SubmitOTP(string otp, string reference);

		Task<ChargeResponse> CheckPendingCharge(string reference);
		Task<ChargeResponse> ChargeAuthorization(string amount, string email, string pin, string authorization_code,
			string display_name = null, string value = null, string variable_name = null);
		Task<ChargeResponse> ChargeAuthorization(ChargeAuthorizationInput model);
	}
}
