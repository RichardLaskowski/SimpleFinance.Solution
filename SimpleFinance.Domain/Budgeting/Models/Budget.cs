using System.Collections.ObjectModel;

namespace SimpleFinance.Domain.Budgeting
{
	public class Budget
	{
		public int BudgetId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<BudgetCategory> Categories { get; set; }

		public Budget(int budgetId, string name, string description, ReadOnlyCollection<BudgetCategory> categories)
		{
			BudgetId = budgetId;
			Name = name;
			Description = description;
			Categories = categories;
		}
	}
}