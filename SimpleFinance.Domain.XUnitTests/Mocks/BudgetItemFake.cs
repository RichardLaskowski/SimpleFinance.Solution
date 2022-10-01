using SimpleFinance.Domain.Budgets.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.XUnitTests.Mocks
{
	internal class BudgetItemFake : IBudgetItem
	{
		public int BudgetItemId { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }

		public BudgetItemFake()
		{

		}
	}
}
