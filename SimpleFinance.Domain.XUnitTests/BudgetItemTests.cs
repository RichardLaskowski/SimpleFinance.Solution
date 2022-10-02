using SimpleFinance.Domain.Budgets.Models;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests;

public class BudgetItemTests
{
    private const int _defaultId = 0;
    private const string _defaultName = "N";
    private const string _defaultDescription = "D";
    private const decimal _defaultAmount = 0;

    [Fact]
    public void BudgetItem_WithValidArguments_ShouldCreateNewBudgetItem()
    {
        //Arrange
        BudgetItem actual;

        //Act
        actual = new BudgetItem(
            _defaultId,
            _defaultName,
            _defaultDescription,
            _defaultAmount,
            DateTime.Today);

        //Assert
        Assert.IsType<BudgetItem>(actual);
    }

    [Fact]
    public void BudgetItem_WithIdNegative_ShouldThrowArgumentOutOfRangeException()
    {
        //Arrange
        int id = -1;
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            id,
            _defaultName,
            _defaultDescription,
            _defaultAmount,
            DateTime.Today);

        //Assert
        Assert.Throws<ArgumentOutOfRangeException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithIdAsMaxValue_ShouldCreateNewBudgetItem()
    {
        //Arrange
        int id = int.MaxValue;
        BudgetItem item;

        //Act
        item = new BudgetItem(
           id,
           _defaultName,
           _defaultDescription,
           _defaultAmount,
               DateTime.Now);

        //Assert
        Assert.IsType<BudgetItem>(item);
    }

    [Fact]
    public void BudgetItem_WithNameNull_ShouldThrowArgumentNullException()
    {
        //Arrange
        string name = null!;
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            name,
            _defaultDescription,
            _defaultAmount,
                DateTime.Now);

        //Assert
        Assert.Throws<ArgumentNullException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithNameAsWhiteSpace_ShouldThrowArgumentException()
    {
        //Arrange
        string name = " ";
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            name,
            _defaultDescription,
            _defaultAmount,
                DateTime.Now);

        //Assert
        Assert.Throws<ArgumentException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithNameEmpty_ShouldThrowArgumentException()
    {
        //Arrange
        string name = "";
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            name,
            _defaultDescription,
            _defaultAmount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentException>(constructor);
    }
    [Fact]
    public void BudgetItem_WithDescriptionNull_ShouldThrowArgumentNullException()
    {
        //Arrange
        string description = null!;
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            _defaultName,
            description,
            _defaultAmount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentNullException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithDescriptionAsWhiteSpace_ShouldThrowArgumentException()
    {
        //Arrange
        string description = " ";
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            _defaultName,
            description,
            _defaultAmount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithDescriptionEmpty_ShouldThrowArgumentException()
    {
        //Arrange
        string description = "";
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            _defaultName,
            description,
            _defaultAmount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithAmountNegative_ShouldThrowArgumentOutOfRangeException()
    {
        //Arrange
        decimal amount = decimal.MinusOne;
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            _defaultName,
            _defaultDescription,
            amount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentOutOfRangeException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithAmountAsMinValue_ShouldThrowArgumentOutOfRangeException()
    {
        //Arrange
        decimal amount = decimal.MinValue;
        BudgetItem item;

        //Act
        void constructor() => item = new BudgetItem(
            _defaultId,
            _defaultName,
            _defaultDescription,
            amount,
                DateTime.Today);

        //Assert
        Assert.Throws<ArgumentOutOfRangeException>(constructor);
    }

    [Fact]
    public void BudgetItem_WithAmountAsZero_ShouldCreateNewBudgetItem()
    {
        //Arrange
        decimal amount = decimal.Zero;
        BudgetItem item;

        //Act
        item = new BudgetItem(
           _defaultId,
           _defaultName,
           _defaultDescription,
           amount,
               DateTime.Today);

        //Assert
        Assert.IsType<BudgetItem>(item);
    }

    [Fact]
    public void BudgetItem_WithAmountPositive_ShouldCreateNewBudgetItem()
    {
        //Arrange
        decimal amount = decimal.One;
        BudgetItem item;

        //Act
        item = new BudgetItem(
           _defaultId,
           _defaultName,
           _defaultDescription,
           amount,
               DateTime.Today);

        //Assert
        Assert.IsType<BudgetItem>(item);
    }

    [Fact]
    public void BudgetItem_WithAmountAsMaxValue_ShouldCreateNewBudgetItem()
    {
        //Arrange
        decimal amount = decimal.MaxValue;
        BudgetItem item;

        //Act
        item = new BudgetItem(
           _defaultId,
           _defaultName,
           _defaultDescription,
           amount,
               DateTime.Today);

        //Assert
        Assert.IsType<BudgetItem>(item);
    }
}