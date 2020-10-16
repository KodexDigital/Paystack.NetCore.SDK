using Paystack.NetCore.SDK.Models;
using Paystack.NetCore.SDK.Models.Authorizations;
using Paystack.NetCore.SDK.Models.Exports;
using Paystack.NetCore.SDK.Models.Transactions;
using Paystack.NetCore.SDK.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface ITransactions
	{
		Task<PaymentInitalizationResponse> InitializeTransaction(string email, int amount, string firstName = null,
		   string lastName = null, string callbackUrl = null, string reference = null, bool makeReferenceUnique = false);

		Task<PaymentInitalizationResponse> InitializeTransaction(TransactionInitializationRequest requestObj);

		Task<TransactionResponses> VerifyTransaction(string reference);

		Task<TransactionListViewModel> ListTransactions();

		Task<TransactionResponses> FetchTransaction(int id);

		Task<TransactionResponses> ChargeAuthorization(string authorization_code, string email, int amount);

		Task<TransactionResponses> TransactionTimeline(string reference);

		Task<TransactionTotal> TransactionTotals();

		Task<ExportResponse> ExportTransactions();

		Task<TransactionResponses> CheckAuthorization(string authorization_code, string email, int amount);

		Task<RequestAuthorization> RequestReAuthorization(string authorization_code, string email, int amount);
	}
}
