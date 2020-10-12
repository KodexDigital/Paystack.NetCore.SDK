using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paystack.NetCore.Models
{
	public class Responses
	{

		[JsonProperty(PropertyName = "status")]
		public bool Status { get; set; }

		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }
	}
}
