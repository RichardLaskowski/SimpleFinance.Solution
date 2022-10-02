using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.XUnitTests.Fakes
{
    internal class BudgetCategoryFake : IBudgetCategory
    {
        public int BudgetCategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ReadOnlyCollection<IBudgetItem> BudgetItems { get; set; }

        public BudgetCategoryFake()
        {

        }
    }
}
