﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFinance.Domain.Budgets.Models.Interfaces;

namespace SimpleFinance.Domain.XUnitTests.Mocks
{
	internal class FakeBudget : IBudget
	{
		public int BudgetId { get; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; set; }
		public ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; set; }

		public FakeBudget()
		{

		}
	}
}