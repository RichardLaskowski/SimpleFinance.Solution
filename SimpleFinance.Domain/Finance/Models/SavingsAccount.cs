using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
	public class SavingsAccount : Account
	{
		public int SavingsAccountId { get => AccountId; }
		public string SavingsAccountNumber => AccountNumber;
		public string AccountName => Name;
		public string AccountDescription => Description;
		public ReadOnlyCollection<Owner> AccountOwners { get; private set; }

		public SavingsAccount(
			int savingsAccountId,
			string savingsAccountNumber,
			string name,
			string description,
			List<Owner> owners) : base(
				savingsAccountId,
				savingsAccountNumber,
				name,
				description,
				owners)
		{
			AccountOwners = Owners;
		}
	}
}