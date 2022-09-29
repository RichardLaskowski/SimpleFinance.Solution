using System.Collections.Generic;

namespace SimpleFinance.Domain.Budget.Models
{
	public class BudgetCategory
	{
		public int BudgetCategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<BudgetItem> Items { get; set; }

		public BudgetCategory(
			int budgetCategoryId,
			string name,
			string description,
			List<BudgetItem> items)
		{
			BudgetCategoryId = budgetCategoryId;
			Name = name;
			Description = description;
			Items = items;
		}

	}
}