using System.Collections.Generic;
using SimpleFinance.Domain.Common.Models;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class Budget
	{
		public int BudgetId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<BudgetCategory> Categories { get; set; }
		public List<Owner> Owners { get; set; }

		public Budget(int budgetId, string name, string description, List<BudgetCategory> categories)
		{
			BudgetId = budgetId;
			Name = name;
			Description = description;
			Categories = categories;
			Owners = new List<Owner>();
		}
	}
}