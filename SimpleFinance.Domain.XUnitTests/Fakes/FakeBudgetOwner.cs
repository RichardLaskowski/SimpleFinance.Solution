using SimpleFinance.Domain.Budgets.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.XUnitTests.Mocks
{
	internal class BudgetOwnerFake : IBudgetOwner
	{
		public int BudgetOwnerId => throw new NotImplementedException();
	}
}
