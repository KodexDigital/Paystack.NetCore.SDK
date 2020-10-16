using Newtonsoft.Json;
using Paystack.NetCore.SDK.Interfaces;
using Paystack.NetCore.SDK.Models.Transfers.Initiations;
using Paystack.NetCore.SDK.Models.Transfers.Recipient;
using Paystack.NetCore.SDK.Models.Transfers.TransferDetails;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Transfers
{
	[Obsolete]
	public class PaystackTransfers : ITransfers
	{
		private readonly string secretKey;

		public PaystackTransfers(string secretKey)
		{
			this.secretKey = secretKey;
		}
		public async Task<TransferRecipient> CreateTransferRecipient(string type, string name, string account_number,
			string bank_code, string currency = "NGN", string description = null)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("type", type),
				new KeyValuePair<string, string>("name", name),
				new KeyValuePair<string, string>("account_number", account_number),
				new KeyValuePair<string, string>("bank_code", bank_code),
				new KeyValuePair<string, string>("currency", currency)
			};

			if (!string.IsNullOrWhiteSpace(description))
				bodyKeyValues.Add(new KeyValuePair<string, string>("description", description));

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transferrecipient", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<TransferRecipient>(json);
			return result;
		}

		public async Task<TransferRecipientList> ListTransferRecipients()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("transferrecipient");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransferRecipientList>(json);
		}
		public async Task<TransferInitiation> InitiateTransfer(int amount, string recipient_code, string source = "balance", string currency = "NGN", string reason = null)
		{
			var client = HttpConnection.CreateClient(secretKey);

			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("source", source),
				new KeyValuePair<string, string>("amount", amount.ToString()),
				new KeyValuePair<string, string>("recipient_code", recipient_code),
				new KeyValuePair<string, string>("currency", currency)
			};

			if (!string.IsNullOrWhiteSpace(reason))
				bodyKeyValues.Add(new KeyValuePair<string, string>("reason", reason));

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transfer", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<TransferInitiation>(json);
			return result;
		}

		public async Task<TransferDetail> FetchTransfer(string transfer_code)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"transfer/{transfer_code}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransferDetail>(json);
		}

		public async Task<TransferDetailList> ListTransfers()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("transfer");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransferDetailList>(json);
		}

		public async Task<string> FinalizeTransfer(string transfer_code, string otp)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("transfer_code", transfer_code),
				new KeyValuePair<string, string>("otp", otp)
			};

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("finalize_transfer", formContent);
			var json = await response.Content.ReadAsStringAsync();
			return json;
		}
	}
}
