using System;
using System.Collections.Generic;
using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.Common.Enums;
using BudgetCategory = SimpleFinance.Domain.Budgets.Models.BudgetCategory;

namespace SimpleFinance.Domain.Budgets.Builders;

internal class BudgetCategoryBuilder
{
	private string _name = "";
	private string _description = "";
	private decimal _allottedAmount = 0;
	private Month _month = Month.January;
	private List<IBudgetItem> _items = new List<IBudgetItem>();

	public BudgetCategory Build() => new BudgetCategory(
		0,
		_name,
		_description,
		_allottedAmount,
		_month,
		_items);

	public BudgetCategoryBuilder WithName(string value)
	{
		_name = value;
		return this;
	}

	public BudgetCategoryBuilder WithDescription(string value)
	{
		_description = value;
		return this;
	}
	public BudgetCategoryBuilder WithAllottedAmount(decimal value)
	{
		_allottedAmount = value;
		return this;
	}
	public BudgetCategoryBuilder WithMonth(Month value)
	{
		_month = value;
		return this;
	}
	public BudgetCategoryBuilder WithItems(List<IBudgetItem> value)
	{
		_items = value;
		return this;
	}
}
