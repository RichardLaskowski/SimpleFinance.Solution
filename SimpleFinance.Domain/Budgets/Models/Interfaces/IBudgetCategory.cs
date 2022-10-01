using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models.Interfaces
{
	public interface IBudgetCategory
	{
		int BudgetCategoryId { get; }
		string Name { get; set; }
		string Description { get; set; }
		ReadOnlyCollection<IBudgetItem> BudgetItems { get; }
	}
}