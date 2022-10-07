using System;
using SimpleFinance.ConsoleApp.Menus;

namespace SimpleFinance.ConsoleApp.Commands.Classes
{
	internal class ProcessResponseCommand : ConsoleCommand
	{
		public IMenu Menu { get; set; }
		public string Response { get; set; }
		public override Action Action { get; set; }

		public ProcessResponseCommand(IMenu menu)
		{
			Menu = menu;
			Action = () => menu.ProcessResponse(Response);
		}

		public ProcessResponseCommand(IMenu menu, string response)
		{
			Menu = menu;
			Response = response;
			Action = () => menu.ProcessResponse(Response);
		}
	}
}
