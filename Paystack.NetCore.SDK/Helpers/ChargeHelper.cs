using Paystack.NetCore.SDK.Fees;

namespace Paystack.NetCore.SDK.Helpers
{
    public static class ChargeHelper
    {
        private static PaystackFee paystackFee = new PaystackFee();

        public static int AddCharge(int amountInKobo) => paystackFee.AddCharge(amountInKobo);
        public static decimal CalculatedCharge(int amountInKobo)
        {
            var amountWithCharge = paystackFee.AddCharge(amountInKobo);
            return ((amountWithCharge - amountInKobo) / 100);
        }
    }
}
