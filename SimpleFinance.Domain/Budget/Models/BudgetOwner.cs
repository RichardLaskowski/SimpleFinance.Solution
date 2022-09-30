using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class BudgetOwner : Owner
	{
		#region Properties

		public int BudgetOwnerId => OwnerId;

		#endregion

		#region Constructor

		public BudgetOwner(
			int budgetOwnerId,
			string firstName,
			string lastName) : base(
				budgetOwnerId,
				firstName,
				lastName)
		{
			GuardBudgetOwner();
		}

		private void GuardBudgetOwner()
		{

		}

		#endregion
	}
}