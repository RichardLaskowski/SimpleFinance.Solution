using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models.Interfaces
{
	public interface IBudget
	{
		int BudgetId { get; }
		string Name { get; set; }
		string Description { get; set; }
		ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; }
		ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; }
	}
}