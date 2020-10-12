using Paystack.NetCore.Constants;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Paystack.NetCore.SDK
{
	public static class HttpConnection
	{
		[Obsolete]
		public static HttpClient CreateClient(string secretKey)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			var client = new HttpClient
			{
				BaseAddress = new Uri(BaseConstants.PaystackBaseEndPoint)
			};
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(BaseConstants.ContentTypeHeaderJson));
			client.DefaultRequestHeaders.Add("cache-control", "no-cache");
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BaseConstants.AuthorizationHeaderType, secretKey);
			return client;
		}
	}
}
