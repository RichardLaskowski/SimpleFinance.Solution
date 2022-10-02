using SimpleFinance.Domain.Common.Models;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests;

public class OwnerTests
{
    [Theory]
    [InlineData(-1, "F", "L")]
    public void Owner_WithIdNegative_ShouldThrowArgumentOutOfRangeException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentOutOfRangeException>(testOwnerConstructor);
    }

    [Theory]
    [InlineData(0, null, "L")]
    public void Owner_WithFirstNameNull_ShouldThrowNullArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentNullException>(testOwnerConstructor);
    }

    [Theory]
    [InlineData(0, "", "L")]
    public void Owner_WithFirstNameEmpty_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentException>(testOwnerConstructor);
    }

    [Theory]
    [InlineData(0, " ", "L")]
    public void Owner_WithFirstNameAsWhiteSpace_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentException>(testOwnerConstructor);
    }

    [Theory]
    [InlineData(0, "F", "")]
    public void Owner_WithLastNameEmpty_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentException>(testOwnerConstructor);
    }

    [Theory]
    [InlineData(0, "F", " ")]
    public void Owner_WithLastNameAsWhiteSpace_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
    {
        //Arrange
        Owner testOwner;

        //Act
        void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

        //Assert
        Assert.Throws<ArgumentException>(testOwnerConstructor);
    }
}