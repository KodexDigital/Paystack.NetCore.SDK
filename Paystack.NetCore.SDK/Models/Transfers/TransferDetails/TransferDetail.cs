﻿using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Transfers.TransferDetails
{
	public class TransferDetail : Responses
	{
		[JsonProperty(PropertyName ="data")]
		public Data Data { get; set; }
	}
}
