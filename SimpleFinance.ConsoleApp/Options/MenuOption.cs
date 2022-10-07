using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.ConsoleApp;

public class MenuOption
{
	public string Description { get; set; }

	public MenuOption(string description)
	{
		Description = description;
	}
}
