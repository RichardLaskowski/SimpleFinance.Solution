using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Finance.Models
{
	public class CheckingAccount : Account
	{
		public int CheckingAccountId => AccountId;
		public string CheckingAccountNumber => AccountNumber;
		public string AccountName => Name;
		public string AccountDescription => Description;
		public ReadOnlyCollection<Owner> AccountOwners { get; private set; }
		public CheckingAccount(int checkingAccountId,
						string checkingAccountNumber,
						string name,
						string description,
						List<Owner> owners) : base(
							checkingAccountId,
							checkingAccountNumber,
							name,
							description,
							owners)
		{
			AccountOwners = Owners;
		}
	}
}