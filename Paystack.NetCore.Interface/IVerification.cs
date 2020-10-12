using Paystack.NetCore.Models.Verifications;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface IVerification
	{
		Task<BvnVerificationResponse> ResolveBVN(string bvn);
	}
}
