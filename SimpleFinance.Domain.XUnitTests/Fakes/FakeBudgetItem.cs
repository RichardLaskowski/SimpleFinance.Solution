using SimpleFinance.Domain.Budgets.Models;

namespace SimpleFinance.Domain.XUnitTests.Fakes;

internal class FakeBudgetItem : IBudgetItem
{
    public int BudgetItemId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }

    public FakeBudgetItem(int budgetItemId = default, string name = "", string description = "", decimal amount = default)
    {
        BudgetItemId = budgetItemId;
        Name = name;
        Description = description;
        Amount = amount;
    }
}
