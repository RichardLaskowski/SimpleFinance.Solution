using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain
{
	public class CreditCardAccount : Account
	{
		public int CreditCardAccountId => AccountId;
		public string CreditCardNumber => AccountNumber;
		public string AccountName => Name;
		public string AccountDescription => Description;
		public decimal Balance { get; private set; }
		public decimal Limit { get; private set; }
		public ReadOnlyCollection<Owner> AccountOwner { get; private set; }

		public CreditCardAccount(
			int creditCardAccountId,
			string creditCardNumber,
			decimal balance,
			decimal limit,
			string name,
			string description,
			List<Owner> owners) : base(
				creditCardAccountId,
				creditCardNumber,
				name,
				description,
				owners)
		{
			AccountOwner = Owners;
			Balance = balance;
			Limit = limit;
		}
	}
}