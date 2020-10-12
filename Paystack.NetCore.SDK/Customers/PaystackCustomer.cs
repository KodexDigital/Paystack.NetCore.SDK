using Newtonsoft.Json;
using Paystack.NetCore.Models.Customers;
using Paystack.NetCore.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Customers
{
	[Obsolete]
	public class PaystackCustomer : ICustomers
	{
		private readonly string secretKey;

		public PaystackCustomer(string secretKey)
		{
			this.secretKey = secretKey;
		}

		public async Task<CreationResponse> CreateCustomer(string email, string firstname = null, string lastname = null, string phone = null)
		{
			var client = HttpConnection.CreateClient(secretKey);

			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("email", email),
				new KeyValuePair<string, string>("first_name", firstname),
				new KeyValuePair<string, string>("last_name", lastname),
				new KeyValuePair<string, string>("phone", phone)
			};

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("customer", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<CreationResponse>(json);
			return result;
		}

		public async Task<CreationResponse> FetchCustomer(int id)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"customer/{id}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<CreationResponse>(json);
		}

		public async Task<ListResponse> ListCustomers()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("customer");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<ListResponse>(json);
		}
	}
}
