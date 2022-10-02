using System.Collections.ObjectModel;
using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.Domain.XUnitTests.Fakes;

internal class FakeBudget : IBudget
{
    public int BudgetId { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; set; }
    public ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; set; }

    internal FakeBudget(int id = default, string name = "", string description = "")
    {
        BudgetId = id;
        Name = name;
        Description = description;
        BudgetCategories = new ReadOnlyCollection<IBudgetCategory>(new List<IBudgetCategory>());
        BudgetOwners = new ReadOnlyCollection<IBudgetOwner>(new List<IBudgetOwner>());
    }
}
