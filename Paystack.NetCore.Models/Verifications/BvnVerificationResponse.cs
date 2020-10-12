using Newtonsoft.Json;

namespace Paystack.NetCore.Models.Verifications
{
	public class BvnVerificationResponse : Responses
	{
		[JsonProperty(PropertyName ="bvn_data")]
		public BvnData BvnData { get; set; }

		[JsonProperty(PropertyName = "bvn_metadata")]
		public BvnMetaData BvnMetaData { get; set; }
	}

}
