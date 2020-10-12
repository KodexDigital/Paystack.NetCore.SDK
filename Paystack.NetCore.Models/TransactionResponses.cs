using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Paystack.NetCore.Models
{
    public class TransactionResponses : Responses
    {
        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }
    }

    public class Metadata
    {
        [JsonProperty(PropertyName = "referrer")]
        public string Referrer { get; set; }
    }

    public class History
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
    }

    public class Log
    {
        [JsonProperty(PropertyName = "time_spent")]
        public int TimeSpent { get; set; }

        [JsonProperty(PropertyName = "attempts")]
        public int Attempts { get; set; }

        [JsonProperty(PropertyName = "authentication")]
        public object Authentication { get; set; }

        [JsonProperty(PropertyName = "errors")]
        public int Errors { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public bool Mobile { get; set; }

        [JsonProperty(PropertyName = "input")]
        public List<object> Input { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public object Channel { get; set; }

        [JsonProperty(PropertyName = "history")]
        public List<History> History { get; set; }
    }

    public class Authorization
    {
        [JsonProperty(PropertyName = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty(PropertyName = "card_type")]
        public string CardType { get; set; }

        [JsonProperty(PropertyName = "last4")]
        public string Last4 { get; set; }

        [JsonProperty(PropertyName = "exp_month")]
        public string ExpMonth { get; set; }

        [JsonProperty(PropertyName = "exp_year")]
        public string ExpYear { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public string Pin { get; set; }

        [JsonProperty(PropertyName = "bank")]
        public string Bank { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }

        [JsonProperty(PropertyName = "reusable")]
        public bool Reusable { get; set; }

        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }
    }

    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }

    public class Data
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "transaction_date")]
        public DateTime TransactionDate { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata MetaData { get; set; }

        [JsonProperty(PropertyName = "gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonProperty(PropertyName = "message")]
        public object Message { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName = "log")]
        public Log Log { get; set; }

        [JsonProperty(PropertyName = "fess")]
        public object Fees { get; set; }

        [JsonProperty(PropertyName = "authorization")]
        public Authorization Authorization { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }
    }
}
