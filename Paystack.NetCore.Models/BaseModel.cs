using Newtonsoft.Json;
using System;

namespace Paystack.NetCore.Models
{
	public class BaseModel
	{
		[JsonProperty(PropertyName = "id")]
		public int Id { get; set; }

		[JsonProperty(PropertyName = "createdAt")]
		public DateTime CreatedAt { get; set; }

		[JsonProperty(PropertyName = "updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}
