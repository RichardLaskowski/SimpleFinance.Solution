using SimpleFinance.ConsoleApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.ConsoleApp.Menus;

public interface IMenu
{
	List<MenuOption> Options { get; }

	Menu AddMenuOption(string description);
	void Print();
	ICommand ProcessResponse(string response);
}
