using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models
{
	public abstract class Expense : DomainModel
	{
		protected internal int ExpenseId { get => _id; }
		protected Expense(int expenseId) : base(expenseId)
		{
		}
	}
}