using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.ConsoleApp.Commands;

public abstract class Command : ICommand
{
	public abstract void Execute();
}
