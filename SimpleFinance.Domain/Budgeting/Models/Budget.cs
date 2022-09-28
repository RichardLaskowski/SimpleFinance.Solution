using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgeting
{
    public class Budget
    {
		public int BudgetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ReadOnlyCollection<BudgetCategory> Categories { get; set; }

	}
}