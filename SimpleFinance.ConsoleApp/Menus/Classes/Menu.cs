using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.ConsoleApp.Commands;
using SimpleFinance.ConsoleApp.Menus;

namespace SimpleFinance.ConsoleApp.Menus;

public abstract class Menu : IMenu
{
	public abstract List<MenuOption> Options { get; set; }
	public Menu AddMenuOption(string description)
	{
		Options.Add(new MenuOption(description));
		return this;
	}

	public void Print()
	{
		for (int i = 0; i < Options.Count; i++)
		{
			MenuOption option = Options[i];
			Console.WriteLine($"{i+1}) {option.Description}");
		}
	}

	public abstract ICommand ProcessResponse(string response);
}
