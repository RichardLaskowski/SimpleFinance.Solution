using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models.Interfaces
{
	public interface IBudgetItem
	{
		int BudgetItemId { get; }
		string Name { get; set; }
		string Description { get; set; }
		decimal Amount { get; set; }
	}
}