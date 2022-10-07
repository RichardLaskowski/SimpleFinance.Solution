using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFinance.ConsoleApp.Menus;

namespace SimpleFinance.ConsoleApp.Commands
{
	public abstract class ConsoleCommand : Command
	{
		public abstract Action Action { get; set; }

		public ConsoleCommand()
		{
		}

		public ConsoleCommand(Action action)
		{
			Action = action;
		}

		public override void Execute()
		{
			Console.Clear();
			Action();
		}
	}
}
