namespace Paystack.NetCore.SDK.Models.Transfers.TransferDetails
{
	public class Recipient : BaseModel
	{
		public int Integration { get; set; }
		public string Domain { get; set; }
		public string Type { get; set; }
		public string Currency { get; set; }
		public string Name { get; set; }
		public Details Details { get; set; }
		public object Metadata { get; set; }
		public string RecipientCode { get; set; }
		public bool Active { get; set; }
	}
}
