using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Expense.Models
{
	public class FixedExpense : Expense
	{
		public int FixedExpenseId { get => ExpenseId; }
		public FixedExpense(int fixedExpenseId) : base(fixedExpenseId)
		{
		}
	}
}