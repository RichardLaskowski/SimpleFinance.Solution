using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models
{
	public class Budget : DomainModel, IBudget
	{
		#region Fields

		private List<IBudgetCategory> _budgetCategories;
		private List<IBudgetOwner> _budgetOwners;

		#endregion

		#region Properties

		public int BudgetId { get => _id; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; private set; }
		public ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; private set; }

		#endregion

		#region Constructor

		public Budget(
				int budgetId,
				string name,
				string description,
				List<IBudgetCategory> budgetCategories,
				List<IBudgetOwner> budgetOwners) : base(budgetId)
		{
			GuardBudget(name, description, budgetCategories, budgetOwners);

			Name = name;
			Description = description;
			_budgetCategories = budgetCategories;
			_budgetOwners = budgetOwners;
			BudgetCategories = new ReadOnlyCollection<IBudgetCategory>(_budgetCategories);
			BudgetOwners = new ReadOnlyCollection<IBudgetOwner>(_budgetOwners);
		}

		private void GuardBudget(string name, string description, List<IBudgetCategory> budgetCategories, List<IBudgetOwner> budgetOwners)
		{
			try
			{
				GuardString(name, nameof(name));
				GuardString(description, nameof(description));
				GuardCollection<IBudgetCategory>(budgetCategories, nameof(budgetCategories));
				GuardCollection<IBudgetOwner>(budgetOwners, nameof(budgetOwners));
			}
			catch (ArgumentException innerException)
			{
				string message = innerException.Message;
				throw new ArgumentException(message, innerException);
			}
		}

		public static Budget CreateNewBudget(string name, string description, int id = 0)
		{
			Budget newBudget;
			List<IBudgetCategory> categories = new List<IBudgetCategory>();
			List<IBudgetOwner> owners = new List<IBudgetOwner>();

			newBudget = new Budget(id, name, description, categories, owners);

			return newBudget;
		}

		#endregion
	}
}