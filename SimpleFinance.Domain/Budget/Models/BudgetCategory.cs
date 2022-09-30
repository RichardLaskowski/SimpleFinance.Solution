using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class BudgetCategory : DomainModel
	{
		#region Fields

		private List<BudgetItem> _budgetItems;

		#endregion

		#region Properties

		public int BudgetCategoryId => _id;
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<BudgetItem> BudgetItems { get; private set; }

		#endregion

		#region Constructor

		public BudgetCategory(
				int budgetCategoryId,
				string name,
				string description,
				List<BudgetItem> budgetItems) : base(budgetCategoryId)
		{
			GuardBudgetCategory(name, description, budgetItems);
			Name = name;
			Description = description;
			_budgetItems = budgetItems;
			BudgetItems = new ReadOnlyCollection<BudgetItem>(_budgetItems);
		}

		private void GuardBudgetCategory(string name, string description, List<BudgetItem> budgetItems)
		{
			GuardString(name, nameof(name));
			GuardString(description, nameof(description));
			GuardCollection<BudgetItem>(budgetItems, nameof(budgetItems));
		}


		#endregion
	}
}