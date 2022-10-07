using SimpleFinance.ConsoleApp.Commands;
using SimpleFinance.ConsoleApp.Commands.Classes;
using SimpleFinance.ConsoleApp.Menus.Classes;
using SimpleFinance.Domain.Budgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SimpleFinance.ConsoleApp.Menus;

public class MainMenu : Menu
{
	private bool _showSubMenu = true;
	public override List<MenuOption> Options { get; set; }
	public BudgetMenu BudgetMenu { get; set; }
	public bool ShowMenu { get; set; }
	public string NextResponse { get; set; }

	public MainMenu()
	{
		Options = new List<MenuOption>();
		AddMenuOption("Select Budget")
			.AddMenuOption("Exit");
		BudgetMenu = new BudgetMenu();
	}

	public override ICommand ProcessResponse(string response)
	{
		PrintMenuCommand PrintMenu = null;
		ProcessResponseCommand ProcessResponse = null;
		ICommand ReturnCommand = null;

		while (_showSubMenu)
		{
			switch (response)
			{
				case "1":
					PrintMenu = new PrintMenuCommand(BudgetMenu);
					ProcessResponse = new ProcessResponseCommand(BudgetMenu);
					break;
				default:
					ReturnCommand = new PrintMenuCommand(this);
					break;
			}

			if (ReturnCommand is null)
			{
				PrintMenu.Execute();
				ProcessResponse.Response = Console.ReadLine();
				ProcessResponse.Execute();
			}
			else
			{
				_showSubMenu = false;
			}
		}

		return ReturnCommand;
	}
}
