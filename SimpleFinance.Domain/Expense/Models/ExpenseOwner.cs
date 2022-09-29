using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models
{
	public class ExpenseOwner : Owner
	{
		public int ExpenseOwnerId => OwnerId;

		public ExpenseOwner(
			int expenseOwnerId,
			string firstName,
			string lastName) : base(
				expenseOwnerId,
				firstName,
				lastName)
		{

		}

	}
}