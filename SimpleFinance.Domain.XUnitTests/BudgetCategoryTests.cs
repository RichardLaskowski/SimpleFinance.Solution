using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.XUnitTests.Fakes;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests;

public class BudgetCategoryTests
{
    private const int _id = 0;
    private const string _name = "N";
    private const string _description = "D";
    private List<IBudgetItem> _items = new List<IBudgetItem> { };

    private BudgetCategory CreateDefaultBudgetCategory()
    {
        BudgetCategory defaultBudgetCategory = new BudgetCategory(
            _id,
            _name,
            _description,
            _items);

        return defaultBudgetCategory;
    }
    private BudgetCategory CreateDefaultBudgetCategory(List<IBudgetItem> items)
    {
        BudgetCategory defaultBudgetCategory = new BudgetCategory(
            _id,
            _name,
            _description,
            items);

        return defaultBudgetCategory;
    }

    [Fact]
    public void AddItem_WithAmountAsOne_ShouldUpdateTotalToOne()
    {
        //Arrange
        BudgetCategory sut = CreateDefaultBudgetCategory();
        FakeBudgetItem fakeBudgetItem = new FakeBudgetItem() { Amount = 1 };

        //Act
        sut.AddItem(fakeBudgetItem);

        //Assert
        Assert.True(sut.Total == 1);
    }
}