using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models
{
	public class BudgetCategory : DomainModel, IBudgetCategory
	{
		#region Fields

		private List<IBudgetItem> _budgetItems;

		#endregion

		#region Properties

		public int BudgetCategoryId => _id;
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<IBudgetItem> BudgetItems { get; private set; }

		#endregion

		#region Constructor

		public BudgetCategory(
				int budgetCategoryId,
				string name,
				string description,
				List<IBudgetItem> budgetItems) : base(budgetCategoryId)
		{
			GuardBudgetCategory(name, description, budgetItems);
			Name = name;
			Description = description;
			_budgetItems = budgetItems;
			BudgetItems = new ReadOnlyCollection<IBudgetItem>(_budgetItems);
		}

		private void GuardBudgetCategory(string name, string description, List<IBudgetItem> budgetItems)
		{
			GuardString(name, nameof(name));
			GuardString(description, nameof(description));
			GuardCollection<IBudgetItem>(budgetItems, nameof(budgetItems));
		}


		#endregion
	}
}