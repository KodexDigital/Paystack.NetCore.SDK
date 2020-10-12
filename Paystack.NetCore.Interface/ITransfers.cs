using Paystack.NetCore.Models.Transfers.Initiations;
using Paystack.NetCore.Models.Transfers.Recipient;
using Paystack.NetCore.Models.Transfers.TransferDetails;
using System.Threading.Tasks;

namespace Paystack.NetCore.Interfaces
{
	public interface ITransfers
	{
		Task<TransferRecipient> CreateTransferRecipient(string type, string name, string account_number,
										   string bank_code, string currency = "NGN", string description = null);
		Task<TransferRecipientList> ListTransferRecipients();
		Task<TransferInitiation> InitiateTransfer(int amount, string recipient_code, string source = "balance", string currency = "NGN", string reason = null);
		Task<TransferDetail> FetchTransfer(string transfer_code);
		Task<TransferDetailList> ListTransfers();
		Task<string> FinalizeTransfer(string transfer_code, string otp);
	}
}
