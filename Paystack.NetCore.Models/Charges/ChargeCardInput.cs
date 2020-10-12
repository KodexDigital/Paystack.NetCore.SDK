using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paystack.NetCore.Models.Charges
{
    public class ChargeCardInput
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public CardMetadata Metadata { get; set; }

        [JsonProperty(PropertyName = "card")]
        public ChargeCard Card { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public string Pin { get; set; }
    }

    public class Custom_Field : AuthCustomField
    {
    }

    public class CardMetadata
    {
        public List<Custom_Field> CustomFields { get; set; }
    }

    public class ChargeCard
    {
        [JsonProperty(PropertyName = "cvv")]
        public string CVV { get; set; }

        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "exp_month")]
        public string ExpiryMonth { get; set; }

        [JsonProperty(PropertyName = "exp_year")]
        public string ExpiryYear { get; set; }
    }
}
