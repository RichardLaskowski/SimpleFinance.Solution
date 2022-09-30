using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models.Base;
using Xunit;

namespace SimpleFinance.Domain.XUnitTests
{
	public class OwnerTests
	{
		[Theory]
		[InlineData(-1, "F", "L")]
		public void Owner_WhenIdLessThanZero_ShouldThrowArgumentOutOfRangeException(int ownerId, string ownerFirstName, string ownerLastName)
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
		public void Owner_WhenFirstNameNull_ShouldThrowNullArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
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
		public void Owner_WhenFirstNameIsEmpty_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
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
		public void Owner_WhenFirstNameIsWhiteSpace_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
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
		public void Owner_WhenLastNameIsEmpty_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
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
		public void Owner_WhenLastNameIsWhiteSpace_ShouldThrowArgumentException(int ownerId, string ownerFirstName, string ownerLastName)
		{
			//Arrange
			Owner testOwner;

			//Act
			void testOwnerConstructor() => testOwner = new Owner(ownerId, ownerFirstName, ownerLastName);

			//Assert
			Assert.Throws<ArgumentException>(testOwnerConstructor);
		}


	}
}