using System;
using CommunityToolkit.Diagnostics;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models;


public class BudgetItem : DomainModel, IBudgetItem
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
