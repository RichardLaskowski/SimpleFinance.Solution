using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain
{
	public class CreditCardAccount
	{
		public int CreditCardAccountId { get; set; }
		public string CreditCardNumber { get; set; }
		public decimal Balance { get; set; }
		public decimal Limit { get; set; }

		public CreditCardAccount(int creditCardAccountId, string creditCardNumber, decimal balance, decimal limit)
		{
			CreditCardAccountId = creditCardAccountId;
			CreditCardNumber = creditCardNumber;
			Balance = balance;
			Limit = limit;
		}
	}
}