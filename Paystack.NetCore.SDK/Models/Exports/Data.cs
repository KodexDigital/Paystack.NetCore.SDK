﻿using Newtonsoft.Json;

namespace Paystack.NetCore.SDK.Models.Exports
{
	public class Data
	{
		[JsonProperty(PropertyName = "path")]
		public string Path { get; set; }
	}
}
