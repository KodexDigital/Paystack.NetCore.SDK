using Newtonsoft.Json;
using Paystack.NetCore.SDK.Interfaces;
using Paystack.NetCore.SDK.Models.Verifications;
using System;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Verifications
{
	public class Verification : IVerification
	{
		private readonly string secretKey;

		public Verification(string secretKey)
		{
			this.secretKey = secretKey;
		}

		[Obsolete]
		public async Task<BvnVerificationResponse> ResolveBVN(string bvn)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"bank/resolve_bvn/{bvn}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<BvnVerificationResponse>(json);
		}
	}
}
