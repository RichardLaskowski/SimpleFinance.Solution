using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFinance.ConsoleApp.Commands;
using SimpleFinance.ConsoleApp.Commands.Classes;
using SimpleFinance.ConsoleApp.Menus.Classes;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.ConsoleApp.Menus
{
	public class BudgetMenu : Menu
	{
		public List<IBudget> Budgets { get; set; }
		public SelectBudgetMenu SelectBudgetMenu { get; set; }
		public override List<MenuOption> Options { get; set; }
		public bool ShowSubMenu { get; set; } = true;
		public BudgetMenu()
		{
			Options = new List<MenuOption>();
			AddMenuOption("Edit Existing")
				.AddMenuOption("Delete Existing")
				.AddMenuOption("Go Back");
		}

		public override ICommand ProcessResponse(string response)
		{
			PrintMenuCommand PrintMenu = null;
			ProcessResponseCommand ProcessResponse = null;
			ICommand ReturnCommand = null;

			while (ShowSubMenu)
			{
				switch (response)
				{
					case "1":
						PrintMenu = new PrintMenuCommand(SimpleFinance.ConsoleApp.Program.SelectBudgetMenu);
						ProcessResponse = new ProcessResponseCommand(SimpleFinance.ConsoleApp.Program.SelectBudgetMenu);
						break;
					case "2":
						PrintMenu = new PrintMenuCommand(SimpleFinance.ConsoleApp.Program.SelectBudgetMenu);
						ProcessResponse = new ProcessResponseCommand(SimpleFinance.ConsoleApp.Program.SelectBudgetMenu);
						break;
					case "3":
						ReturnCommand = new PrintMenuCommand(new MainMenu());
						break;
					default:
						ReturnCommand = new PrintMenuCommand(new MainMenu());
						break;
				}

				if (ReturnCommand is null)
				{
					PrintMenu.Execute();
					ProcessResponse.Response = Console.ReadLine();
				}
				else
				{
					ShowSubMenu = false;
				}
			}

			return ReturnCommand;
		}
	}
}
