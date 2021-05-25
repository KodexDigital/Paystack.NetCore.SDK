using Paystack.NetCore.SDK.SDK.Fees;

namespace Paystack.NetCore.SDK.Helpers
{
    public static class ChargeHelper
    {
        private static PaystackFee PaystackFee = new PaystackFee();

        public static int AddCharge(int amountInKobo) => PaystackFee.AddCharge(amountInKobo);
        public static decimal CalculatedCharge(int amountInKobo)
        {
            var amountWithCharge = PaystackFee.AddCharge(amountInKobo);
            return ((amountWithCharge - amountInKobo) / 100);
        }
    }
}
