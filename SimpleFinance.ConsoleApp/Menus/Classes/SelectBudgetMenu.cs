using System;
using System.Collections.Generic;
using System.Linq;
using SimpleFinance.ConsoleApp.Commands;
using SimpleFinance.ConsoleApp.Commands.Classes;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.ConsoleApp.Menus.Classes;

public class SelectBudgetMenu : Menu
{
	public override List<MenuOption> Options { get; set; }
	public List<IBudget> Budgets { get; set; }
	public bool ShowSubMenu { get; private set; }

	public SelectBudgetMenu(List<IBudget> budgets)
	{
		Options = new List<MenuOption>();
		Budgets = budgets;
		var budgetNames = from b in budgets
						  select b.Name;

		foreach (string name in budgetNames)
		{
			AddMenuOption(name);
		}
	}

	public override ICommand ProcessResponse(string response)
	{
		SimpleFinance.ConsoleApp.Program.SelectedBudget = (Budget)Budgets.ElementAt(int.Parse(response));
		return new PrintMenuCommand(SimpleFinance.ConsoleApp.Program.BudgetMenu);
	}
}
