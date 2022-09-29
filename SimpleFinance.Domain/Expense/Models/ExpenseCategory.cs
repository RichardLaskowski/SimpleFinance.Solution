using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models;

public class ExpenseCategory : Category
{
	public int ExpenseCategoryId => CategoryId;
	public string CategoryName => Name;
	public string CategoryDescription => Description;

	public ExpenseCategory(int expenseCategoryId, string name, string description) : base(expenseCategoryId, name, description)
	{
	}
}