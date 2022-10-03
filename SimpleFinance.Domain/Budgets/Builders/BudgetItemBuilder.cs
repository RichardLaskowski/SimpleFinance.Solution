using System;

namespace SimpleFinance.Domain.Budgets.Models;

internal class BudgetItemBuilder
{
	private string _name = "";
	private string _description = "";
	private decimal _amount = 0;
	private DateTime _date = DateTime.Now;

	public BudgetItem Build() => new BudgetItem(0, _name, _description, _amount, _date);

	public BudgetItemBuilder WithName(string value)
	{
		_name = value;
		return this;
	}

	public BudgetItemBuilder WithDescription(string value)
	{
		_description = value;
		return this;
	}

	public BudgetItemBuilder WithAmount(decimal value)
	{
		_amount = value;
		return this;
	}

	public BudgetItemBuilder WithDate(DateTime value)
	{
		_date = value;
		return this;
	}
}
