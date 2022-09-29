using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Income
{
	public class BankAccount
	{
		public int BankAccountId { get; set; }
		public string AccountNumber { get; set; }
		List<Owner> Owners { get; set; }
	}
}