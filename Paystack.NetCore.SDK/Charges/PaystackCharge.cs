using Newtonsoft.Json;
using Paystack.NetCore.SDK.Constants;
using Paystack.NetCore.SDK.Interfaces;
using Paystack.NetCore.SDK.Models.Charges;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Charges
{
	[Obsolete]
	public class PaystackCharge: ICharge
	{
		private readonly string secretKey;
		public PaystackCharge(string secretKey)
		{
			this.secretKey = secretKey;
		}

		
		public async Task<ChargeResponse> ChargeAuthorization(string amount, string email, string pin, string authorization_code, string display_name = null, string value = null, string variable_name = null)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var model = new ChargeAuthorizationInput
			{
				AuthorizationCode = authorization_code,
				Amount = amount,
				Email = email,
				Pin = pin
			};
			if (!string.IsNullOrWhiteSpace(display_name))
			{
				_ = new ChargeMetadata
				{
					AuthCustomFields = new List<AuthCustomField>
					{
						new AuthCustomField{ }
					}
				};

			}

			var jsonObj = JsonConvert.SerializeObject(model);
			var content = new StringContent(jsonObj, Encoding.UTF8, BaseConstants.ContentTypeHeaderJson);
			content.Headers.ContentType = new MediaTypeHeaderValue(BaseConstants.ContentTypeHeaderJson);
			var response = await client.PostAsync("charge", content).ConfigureAwait(false);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<ChargeResponse>(json);

			return result;
		}

		public async Task<ChargeResponse> ChargeAuthorization(ChargeAuthorizationInput model)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var jsonObj = JsonConvert.SerializeObject(model);
			var content = new StringContent(jsonObj, Encoding.UTF8, BaseConstants.ContentTypeHeaderJson);
			content.Headers.ContentType = new MediaTypeHeaderValue(BaseConstants.ContentTypeHeaderJson);
			var response = await client.PostAsync("charge", content);
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<ChargeResponse>(json);
		}

		public async Task<ChargeResponse> ChargeCard(string email, string amount, string pin, string cvv, string expiry_month, string expiry_year, string number, string display_name = null, string value = null, string variable_name = null)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var model = new ChargeCardInput
			{
				Amount = amount,
				Card = new ChargeCard
				{
					CVV = cvv,
					ExpiryMonth = expiry_month,
					ExpiryYear = expiry_year,
					Number = number
				},
				Email = email,
				Pin = pin
			};

			if (!string.IsNullOrWhiteSpace(display_name))
			{
				var metaData = new CardMetadata
				{
					CustomFields = new List<Custom_Field>
					{
						new Custom_Field()
						{
							DisplayName = display_name,
							Value = value,
							VariableName = variable_name
						}
					}
				};
				model.Metadata = metaData;
			}

			var jsonObj = JsonConvert.SerializeObject(model);
			var content = new StringContent(jsonObj, Encoding.UTF8, BaseConstants.ContentTypeHeaderJson);
			content.Headers.ContentType = new MediaTypeHeaderValue(BaseConstants.ContentTypeHeaderJson);
			var response = await client.PostAsync("charge", content);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<ChargeResponse>(json);

			return result;
		}

		public async Task<ChargeResponse> CheckPendingCharge(string reference)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var response = await client.GetAsync($"charge/{reference}");
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<ChargeResponse>(json);
		}

		public async Task<ChargeResponse> SubmitOTP(string otp, string reference)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("otp", otp),
				new KeyValuePair<string, string>("reference", reference)
			};
			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("charge/submit_otp", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<ChargeResponse>(json);
			return result;
		}

		public async Task<ChargeResponse> SubmitPin(string pin, string reference)
		{
			var client = HttpConnection.CreateClient(secretKey);
			var bodyKeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("pin", pin),
				new KeyValuePair<string, string>("reference", reference)
			};
			var formContent = new FormUrlEncodedContent(bodyKeyValues);
			var response = await client.PostAsync("charge/submit_pin", formContent);
			var json = await response.Content.ReadAsStringAsync();
			var result =  JsonConvert.DeserializeObject<ChargeResponse>(json);
			return result;
		}
	}
}
