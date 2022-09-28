using System.Collections.ObjectModel;

namespace SimpleFinance.Domain.Budgeting
{
	public class BudgetCategory
	{
		public int BudgetCategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<BudgetItem> Items { get; set; }

		public BudgetCategory(
			int budgetCategoryId,
			string description,
			ReadOnlyCollection<BudgetItem> items)
		{
			BudgetCategoryId = budgetCategoryId;
			Description = description;
			Items = items;
		}

	}
}