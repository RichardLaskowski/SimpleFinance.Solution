using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.XUnitTests.Fakes;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests;

public class BudgetTests
{
    public Budget CreateBudget(int budgetId, string budgetName, string budgetDescription)
    {
        List<IBudgetOwner> budgetOwnerFakes = new List<IBudgetOwner>
        {
            new BudgetOwnerFake()
        };

        List<IBudgetCategory> budgetCategoryFakes = new List<IBudgetCategory>()
        {
            new BudgetCategoryFake()
        };

        Budget budget = new Budget(
            budgetId,
            budgetName,
            budgetDescription,
            budgetCategoryFakes,
            budgetOwnerFakes);

        return budget;
    }

    [Fact]
    public void CreateNewBudget_CreatesNewBudget()
    {
        //Arrange
        Budget actual;

        //Act
        actual = Budget.Create();

        //Assert
        Assert.IsType<Budget>(actual);
    }

    [Fact]
    public void CreateNewCategory_WithName_ShouldCreateNewCategoryContainingName()
    {
        //Arrange


        //Act


        //Assert

    }


}