using Paystack.NetCore.Models.CreateSubAccounts;
using Paystack.NetCore.Models.SubAccounts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paystack.NetCore.SDK.Interfaces
{
	public interface ISubAccounts
	{
		Task<SubAccount> CreateSubAccount(string business_name, string settlement_bank, string account_number, float percentage_charge,
			   string primary_contact_email = null, string primary_contact_name = null, string primary_contact_phone = null, string settlement_schedule = "auto");

		Task<SubAccount> UpdateSubAccount(string subaccount_code, string business_name = null, string settlement_bank = null, string account_number = null,
			float percentage_charge = 0,
			string primary_contact_email = null, string primary_contact_name = null, string primary_contact_phone = null, string settlement_schedule = "auto");


		Task<SubAccount> FetchSubAccount(string subaccount_code);

		Task<SubAccountList> ListSubAccounts();
	}
}
