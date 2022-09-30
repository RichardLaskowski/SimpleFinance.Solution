using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class Budget : DomainModel
	{
		#region Fields

		private List<BudgetCategory> _budgetCategories;
		private List<BudgetOwner> _budgetOwners;

		#endregion

		#region Properties

		public int BudgetId { get => _id; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<BudgetCategory> BudgetCategories { get; private set; }
		public ReadOnlyCollection<BudgetOwner> BudgetOwners { get; private set; }

		#endregion

		#region Constructor

		public Budget(
				int budgetId,
				string name,
				string description,
				List<BudgetCategory> budgetCategories,
				List<BudgetOwner> budgetOwners) : base(budgetId)
		{
			GuardBudget(name, description, budgetCategories, budgetOwners);

			Name = name;
			Description = description;
			_budgetCategories = budgetCategories;
			_budgetOwners = budgetOwners;
			BudgetCategories = new ReadOnlyCollection<BudgetCategory>(_budgetCategories);
			BudgetOwners = new ReadOnlyCollection<BudgetOwner>(_budgetOwners);
		}

		private void GuardBudget(string name, string description, List<BudgetCategory> budgetCategories, List<BudgetOwner> budgetOwners)
		{
			GuardString(name, nameof(name));
			GuardString(description, nameof(description));
			GuardCollection<BudgetCategory>(budgetCategories, nameof(budgetCategories));
			GuardCollection<BudgetOwner>(budgetOwners, nameof(budgetOwners));
		}

		#endregion
	}
}