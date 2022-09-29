using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
	public class FinanceAccount : Account
	{
		public int FinanceAccountId => AccountId;
		public string FinanceAccountNumber => AccountNumber;
		public string AccountName => Name;
		public string AccountDescription => Description;
		public ReadOnlyCollection<Owner> AccountOwners { get; private set; }
		public FinanceAccount(int financeAccountId,
						string financeAccountNumber,
						string name,
						string description,
						List<Owner> owners) : base(
							financeAccountId,
							financeAccountNumber,
							name,
							description,
							owners)
		{
			AccountOwners = Owners;
		}
	}
}