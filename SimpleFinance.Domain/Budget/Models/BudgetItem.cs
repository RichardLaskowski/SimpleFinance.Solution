using CommunityToolkit.Diagnostics;
using SimpleFinance.Domain.Common.Models.Base;
using System;

namespace SimpleFinance.Domain.Budget.Models
{
	public class BudgetItem : DomainModel
	{
		#region Properties

		public int BudgetItemId => _id;
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }

		#endregion

		#region Constructor

		public BudgetItem(int budgetItemId,
				string name,
				string description,
				decimal amount) : base(budgetItemId)
		{
			GuardBudgetItem(name, description, amount);

			Name = name;
			Description = description;
			Amount = amount;
		}

		private void GuardBudgetItem(string name, string description, decimal amount)
		{
			GuardString(name, nameof(name));
			GuardString(description, nameof(description));
			GuardDecimal(amount, nameof(amount));
		}

		#endregion
	}
}