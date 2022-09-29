namespace SimpleFinance.Domain.Expense.Models
{
	public class VariableExpense : Expense
	{
		public int VariableExpenseId { get => ExpenseId; }

		public VariableExpense(int variableExpenseId) : base(variableExpenseId)
		{
		}
	}
}