using Newtonsoft.Json;
using System.Collections.Generic;

namespace Paystack.NetCore.SDK.Models.Transactions
{
	public class Data
	{
		[JsonProperty(PropertyName ="total_transactions")]
		public int TotalTransactions { get; set; }

		[JsonProperty(PropertyName = "unique_customers")]
		public int UniqueCustomers { get; set; }

		[JsonProperty(PropertyName = "total_volume")]
		public int TotalVolume { get; set; }

		[JsonProperty(PropertyName = "total_volume_by_currency")]
		public List<TotalVolumeByCurrency> TotalVolumeByCurrency { get; set; }

		[JsonProperty(PropertyName = "pending_transfers")]
		public int PendingTransfers { get; set; }

		[JsonProperty(PropertyName = "pending_transfers_by_currency")]
		public List<PendingTransfersByCurrency> PendingTransfersByCurrency { get; set; }
	}
}
