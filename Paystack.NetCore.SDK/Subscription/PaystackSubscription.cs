using Newtonsoft.Json;
using Paystack.NetCore.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Subscription
{
    [Obsolete]
    public class PaystackSubscription : ISubscriptions
    {
        private readonly string secretKey;

        public PaystackSubscription(string secretKey)
        {
            this.secretKey = secretKey;
        }

        public async Task<Models.Subscriptions.Subscription> CreateSubscription(string customerEmail, string planCode, string authorization, string start_date)
        {
            var client = HttpConnection.CreateClient(secretKey);

            var bodyKeyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("customer", customerEmail),
                new KeyValuePair<string, string>("plan", planCode),
                new KeyValuePair<string, string>("authorization", authorization),
                new KeyValuePair<string, string>("start_date", start_date)
            };

            var formContent = new FormUrlEncodedContent(bodyKeyValues);
            var response = await client.PostAsync("subscription", formContent);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Models.Subscriptions.Subscription>(json);
            return result;
        }
    }
}
