using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SimpleFinance.Domain.Budgets.Models
{
	internal class BudgetBuilder
	{
		private string _name = "";
		private string _description = "";
		private List<IBudgetCategory> _budgetCategories = new List<IBudgetCategory>();
		private List<IBudgetOwner> _budgetOwners = new List<IBudgetOwner>();

		public Budget Build() => new Budget(
			0,
			_name,
			_description,
			_budgetCategories,
			_budgetOwners);

		public BudgetBuilder WithName(string value)
		{
			_name = value;
			return this;
		}
		public BudgetBuilder WithDescription(string value)
		{
			_description = value;
			return this;
		}
		public BudgetBuilder WithBudgetCategories(List<IBudgetCategory> value)
		{
			_budgetCategories = value;
			return this;
		}
		public BudgetBuilder WithBudgetOwners(List<IBudgetOwner> value)
		{
			_budgetOwners = value;
			return this;
		}
	}
}
