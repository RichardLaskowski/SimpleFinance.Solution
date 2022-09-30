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

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}


	}
}