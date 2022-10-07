using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.ConsoleApp.Menus;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.ConsoleApp.Commands.Classes;

public class SelectBudgetCommand : ConsoleCommand
{
	public SelectBudgetCommand()
	{
	}

	public SelectBudgetCommand(Action action) : base(action)
	{
	}

	public override Action Action { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
