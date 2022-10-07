using System;
using System.Linq;
using SimpleFinance.ConsoleApp.Menus;

namespace SimpleFinance.ConsoleApp.Commands;

public class PrintMenuCommand : ConsoleCommand
{
	private readonly IMenu _menu;
	public override Action Action { get; set; }

	public PrintMenuCommand(IMenu menu) : base()
	{
		_menu = menu;
		Action = () =>
		{
			for (int i = 0; i < _menu.Options.Count; i++)
			{
				MenuOption option = _menu.Options.ElementAt(i);
				Console.WriteLine($"{i + 1}) {option.Description}");
			}
		};
	}

}
