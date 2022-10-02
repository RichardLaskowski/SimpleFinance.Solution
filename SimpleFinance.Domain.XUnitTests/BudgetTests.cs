using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using SimpleFinance.Domain.XUnitTests.Mocks;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests
{
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
			int budgetId = 0;
			string budgetName = "N";
			string budgetDescription = "D";

			Budget actual;

			//Act
			actual = Budget.CreateNewBudget(budgetName, budgetDescription, budgetId);

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
}