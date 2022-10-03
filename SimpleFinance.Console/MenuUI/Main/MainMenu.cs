using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.Console.MenuUI.Main;

internal class MainMenu
{
	internal string _response;

	public void Print()
	{
		System.Console.WriteLine("1. Create New Budget.");
		System.Console.WriteLine("2. List Budgets.");
		_response = Console.ReadLine();
	}

	public void ProcessResponse()
	{
		switch (_response)
		{
			case "1":
				CreateNewBudget();
				break;
			case "2":
				ListBudgets();
				break;
			default:
				Print();
				break;
		}
	}

	private void ListBudgets()
	{
		throw new NotImplementedException();
	}

	private Budget CreateNewBudget()
	{
		Budget new budget = Budget.Create();
	}
}
