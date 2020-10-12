using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Paystack.NetCore.Models.Charges
{
    public class ChargeResponse : Responses
    {
        public ChargeData Data { get; set; }
    }

    public class ChargeCustomer
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public object FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public object LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "customer_code")]
        public string CustomerCode { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public object Phone { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public object Metadata { get; set; }

        [JsonProperty(PropertyName = "risk_action")]
        public string RiskAction { get; set; }
    }

    public class ChargeData
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
        public ChargeMetadata Metadata { get; set; }

        [JsonProperty(PropertyName = "gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonProperty(PropertyName = "message")]
        public object Message { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "ip_addres")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName = "log")]
        public object Log { get; set; }

        [JsonProperty(PropertyName = "fess")]
        public int Fees { get; set; }

        [JsonProperty(PropertyName = "authorization")]
        public Authorization Authorization { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "plan")]
        public object Plan { get; set; }
    }

    public class ChargeMetadata
    {
        public List<AuthCustomField> AuthCustomFields { get; set; }
    }


    public class ChargeAuthorization
    {

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public string Pin { get; set; }

        [JsonProperty(PropertyName = "last4")]
        public string Last4 { get; set; }

        [JsonProperty(PropertyName = "exp_month")]
        public string ExpMonth { get; set; }

        [JsonProperty(PropertyName = "exp_year")]
        public string ExpYear { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "card_type")]
        public string CardType { get; set; }

        [JsonProperty(PropertyName = "bank")]
        public string Bank { get; set; }

        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        [JsonProperty(PropertyName = "resusable")]
        public bool Reusable { get; set; }

        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }

    }

    public class CustomField
    {
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "variable_name")]
        public string VariableName { get; set; }
    }
}
