using Newtonsoft.Json;
using Paystack.NetCore.SDK.Interfaces;
using Paystack.NetCore.SDK.Models;
using Paystack.NetCore.SDK.Models.Authorizations;
using Paystack.NetCore.SDK.Models.Exports;
using Paystack.NetCore.SDK.Models.Transactions;
using Paystack.NetCore.SDK.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Transactions
{
	[Obsolete]
	public class PaystackTransaction : ITransactions
	{
		private readonly string secretKey;

		public PaystackTransaction(string secretKey)
		{
			this.secretKey = secretKey;
		}
		/// <summary>
		/// Sends body parameters to transaction initialization url
		/// </summary>
		/// <param name="email"></param>
		/// <param name="amount"></param>
		/// <param name="firstName"></param>        
		/// <param name="lastName"></param>
		/// <param name="callbackUrl"></param>
		/// <param name="reference"></param>
		/// <param name="makeReferenceUnique"></param>
		/// <returns>PaymentInitalizationResponseModel</returns>

		public async Task<PaymentInitalizationResponse> InitializeTransaction(string email, int amount, string firstName = null,
																				string lastName = null, string callbackUrl = null,
																				string reference = null, bool makeReferenceUnique = false)
		{

			var client = HttpConnection.CreateClient(secretKey);

			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("email", email),
				new KeyValuePair<string, string>("amount", amount.ToString())
			};


			//Optional Params

			if (!string.IsNullOrWhiteSpace(firstName))
				bodyKeyValues.Add(new KeyValuePair<string, string>("first_name", firstName));

			if (!string.IsNullOrWhiteSpace(lastName))
				bodyKeyValues.Add(new KeyValuePair<string, string>("last_name", lastName));

			if (!string.IsNullOrWhiteSpace(callbackUrl))
				bodyKeyValues.Add(new KeyValuePair<string, string>("callback_url", callbackUrl));

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transaction/initialize", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<PaymentInitalizationResponse>(json);
			return result;
		}

		/// <summary>
		/// This methods initializes payment transactioons - It inlcude subaccount, transactioncharge etc
		/// </summary>
		/// <param name="email"></param>
		/// <param name="amount"></param>
		/// <param name="subaccount"></param>
		/// <param name="transaction_charge"></param>
		/// <param name="bearer"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="callbackUrl"></param>
		/// <param name="reference"></param>
		/// <param name="plan"></param>
		/// <param name="invoice_limit"></param>
		/// <param name="makeReferenceUnique"></param>
		/// <returns></returns>

		public async Task<PaymentInitalizationResponse> InitializeTransaction(TransactionInitializationRequest requestObj)
		{

			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>();

			foreach (var property in requestObj.GetType().GetProperties())
				if (property.GetValue(requestObj) != null)
					bodyKeyValues.Add(new KeyValuePair<string, string>(property.Name, property.GetValue(requestObj).ToString()));

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transaction/initialize", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<PaymentInitalizationResponse>(json); ;
			return result;
		}



		/// <summary>
		/// Verifies transaction by reference number
		/// </summary>
		/// <param name="reference"></param>
		/// <returns>TransactionVerificationResponseModel</returns>

		public async Task<TransactionResponses> VerifyTransaction(string reference)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"transaction/verify/{reference}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransactionResponses>(json);
		}


		public async Task<TransactionListViewModel> ListTransactions()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("transaction");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransactionListViewModel>(json);
		}

		public async Task<TransactionResponses> FetchTransaction(int id)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"transaction/{id}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransactionResponses>(json);
		}

		public async Task<TransactionResponses> ChargeAuthorization(string authorization_code, string email, int amount)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("authorization_code", authorization_code),
				new KeyValuePair<string, string>("email", email),
				new KeyValuePair<string, string>("amount", amount.ToString())
			};

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transaction/charge_authorization", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<TransactionResponses>(json);
			return result;
		}

		public async Task<TransactionResponses> TransactionTimeline(string reference)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"transaction/timeline/{reference}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransactionResponses>(json);
		}

		public async Task<TransactionTotal> TransactionTotals()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("transaction/totals");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TransactionTotal>(json);
		}

		public async Task<ExportResponse> ExportTransactions()
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync("transaction/export");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<ExportResponse>(json);
		}

		public async Task<TransactionResponses> CheckAuthorization(string authorization_code, string email, int amount)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("authorization_code", authorization_code),
				new KeyValuePair<string, string>("email", email),
				new KeyValuePair<string, string>("amount", amount.ToString())
			};

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transaction/check_authorization", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<TransactionResponses>(json); ;
			return result;
		}

		public async Task<RequestAuthorization> RequestReAuthorization(string authorization_code, string email, int amount)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("authorization_code", authorization_code),
				new KeyValuePair<string, string>("email", email),
				new KeyValuePair<string, string>("amount", amount.ToString())
			};

			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("transaction/request_reauthorization", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<RequestAuthorization>(json);
			return result;
		}
	}
}
