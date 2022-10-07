using System;
using System.Collections.Generic;
using SimpleFinance.ConsoleApp.Commands;
using SimpleFinance.ConsoleApp.Menus;
using SimpleFinance.ConsoleApp.Menus.Classes;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.ConsoleApp;

internal class Program
{
	public static MainMenu MainMenu = new MainMenu();
	public static BudgetMenu BudgetMenu = new BudgetMenu();
	public static SelectBudgetMenu SelectBudgetMenu = new SelectBudgetMenu(new List<IBudget>
		{
			Budget.Create("Budget One", "My first budget."),
			Budget.Create("Budget Two", "My second budget."),
			Budget.Create("Budget Three", "My third budget.")
		});

	public static Budget SelectedBudget = Budget.Create();

	public static void Main(string[] args)
	{
		ICommand NextCommand;
		string response;
		bool ShowMenu = true;
		NextCommand = new PrintMenuCommand(MainMenu);

		while (ShowMenu)
		{
			NextCommand.Execute();

			response = Console.ReadLine();

			NextCommand = MainMenu.ProcessResponse(response);
		}
	}
}