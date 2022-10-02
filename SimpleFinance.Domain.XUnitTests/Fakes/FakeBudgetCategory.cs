using SimpleFinance.Domain.Budgets.Models;
using System.Collections.ObjectModel;

namespace SimpleFinance.Domain.XUnitTests.Fakes
{
    internal class BudgetCategoryFake : IBudgetCategory
    {
        public int BudgetCategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ReadOnlyCollection<IBudgetItem> BudgetItems { get; set; }

        public BudgetCategoryFake(int id = default, string name = "", string description = "")
        {
            BudgetCategoryId = id;
            Name = name;
            Description = description;
            BudgetItems = new ReadOnlyCollection<IBudgetItem>(new List<IBudgetItem>());

        }
    }
}
